using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIT_SENAI_Windows_Forms.DAL;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace PIT_SENAI_Windows_Forms.DAL
{
    class Configuraçoes
    {
        public string mensagem = "", mefeito = "Alterações salvas. " +
                "Pode ser necessario relogar para que todas as alterações tomem efeito.";
        Conexao conexao = new Conexao();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        #region Receber Dados
        public DataTable ConfigGerais()
        {
            cmd = new SqlCommand();
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();

            cmd.CommandText = @"
                select nome, usuario, email, temperfilmusico, temperfilorganizador
                from cadastro
                where id = @id";
            cmd.Parameters.AddWithValue("@id", Logar.userid);
            try
            {
                cmd.Connection = conexao.Conectar();
                da.Fill(dt);
            }
            catch (SqlException e)
            {
                this.mensagem = e.Message;
                Debug.WriteLine(e.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
            return dt;
        }
        public DataTable ConfigPOrganizador()
        {
            cmd = new SqlCommand();
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();

            cmd.CommandText = @"
                select descriçao, regiao
                from porganizador
                where id = @id";
            cmd.Parameters.AddWithValue("@id", Logar.userid);
            try
            {
                cmd.Connection = conexao.Conectar();
                da.Fill(dt);
            }
            catch (SqlException e)
            {
                this.mensagem = e.Message;
                Debug.WriteLine("Erro no ConfigPOrganizador: " + e.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
            return dt;
        }
        public DataTable ConfigPMusico()
        {
            cmd = new SqlCommand();
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();

            cmd.CommandText = @"
                select descriçao, regiao,contato, publico
                from pmusico
                where id = @id";
            cmd.Parameters.AddWithValue("@id", Logar.userid);

            try
            {
                cmd.Connection = conexao.Conectar();
                da.Fill(dt);
            }
            catch (SqlException e)
            {
                Debug.WriteLine(e.Message);
                this.mensagem = e.Message;
            }
            finally
            {
                conexao.Desconectar();
            }
            return dt;
        }
        public List<string> ConfigMInst()
        {
            cmd = new SqlCommand();
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();

            List<string> l = new List<string>();

            cmd.CommandText = @"
                select i.instrumento
                from instrumentosdosmusicos as m
                inner join instrumento as i
                on m.instrumentoid = i.id
                where musicoID = @id";
            cmd.Parameters.AddWithValue("@id", Logar.userid);
            try
            {
                cmd.Connection = conexao.Conectar();
                da.Fill(dt);
            }
            catch (SqlException e)
            {
                this.mensagem = e.Message;
                Debug.WriteLine(e.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
            for(int i = 0; i< dt.Rows.Count; i++)
            {
                l.Add(dt.Rows[i][0].ToString());
            }
            return l;
        }
        public List<string> ConfigMEstilo()
        {
            cmd = new SqlCommand();
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            List<string> l = new List<string>();

            cmd.CommandText = @"
                select e.estiloMusical
                from estilomusical as e
                inner join estilosdosmusicos as m
                on e.id = m.estiloID
                where m.musicoid = @id";
            cmd.Parameters.AddWithValue("@id", Logar.userid);

            try
            {
                cmd.Connection = conexao.Conectar();
                da.Fill(dt);
            }
            catch (SqlException e)
            {
                this.mensagem = e.Message;
                Debug.WriteLine(e.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                l.Add(dt.Rows[i][0].ToString());
            }
            return l;
        }

        #endregion

        #region Enviar Dados
        //overload para salvar ambos os perfils musico e organizador
        public void ConfigSalvar(string nome, string usuario, string email,string senha,
            string descriçaoO, string regiaoO,
            string descriçaoM, string regiaoM, string contato, bool publico,
            List<int> inst, List<int> estilos)
        {
            cmd = new SqlCommand();
            //salvar configurações
            cmd.CommandText = @"
            update cadastro set nome = @nome where id = @id
            update cadastro set usuario = @usuario where id = @id
            update cadastro set email = @email where id = @id
            update porganizador set descriçao = @descriçaoO where id = @id
            update porganizador set regiao = @regiaoO where id = @id
            update pmusico set descriçao = @descriçaoM where id = @id
            update pmusico set regiao = @regiaoM where id = @id
            update pmusico set contato = @contato where id = @id
            update pmusico set publico = @publico where id = @id";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@descriçaoO", descriçaoO);
            cmd.Parameters.AddWithValue("@regiaoO", regiaoO);
            cmd.Parameters.AddWithValue("@descriçaoM", descriçaoM);
            cmd.Parameters.AddWithValue("@regiaoM", regiaoM);
            cmd.Parameters.AddWithValue("@contato", contato);
            cmd.Parameters.AddWithValue("@publico", publico);
            cmd.Parameters.AddWithValue("@id", Logar.userid);
            try
            {
                //abrir a conexão
                cmd.Connection = conexao.Conectar();
                //executar o comando
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Debug.WriteLine(e.Message);
                this.mensagem = e.Message;
            }
            finally
            {
                //fechar a conexão
                conexao.Desconectar();
            }
            this.mensagem = mefeito;
            //salvar lista de instrumentos
            AlterarInst(inst);
            //salvar lista de estilos
            AlterarEstilos(estilos);
            //se houver alteração na senha, alterar senha
            if (senha.Trim().Length > 0) AlterarSenha(senha);
        }
        //overload para salvar perfil organizador
        public void ConfigSalvar(string nome, string usuario, string email, string senha,
            string descriçaoO, string regiaoO)
        {
            cmd = new SqlCommand();
            //salvar configurações
            cmd.CommandText = @"
            update cadastro set nome = @nome where id = @id
            update cadastro set usuario = @usuario where id = @id
            update cadastro set email = @email where id = @id
            update porganizador set descriçao = @descriçaoO where id = @id
            update porganizador set regiao = @regiaoO where id = @id";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@descriçaoO", descriçaoO);
            cmd.Parameters.AddWithValue("@regiaoO", regiaoO);
            cmd.Parameters.AddWithValue("@id", Logar.userid);
            try
            {
                //abrir a conexão
                cmd.Connection = conexao.Conectar();
                //executar o comando
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Debug.WriteLine(e.Message);
                this.mensagem = e.Message;
            }
            finally
            {
                //fechar a conexão
                conexao.Desconectar();
            }
            this.mensagem = mefeito;
            //se houver alteração na senha, alterar senha
            if (senha.Trim().Length > 0) AlterarSenha(senha);
        }
        //overload para salvar perfil musico
        public void ConfigSalvar(string nome, string usuario, string email, string senha,
            string descriçaoM, string regiaoM, string contato, bool publico,
            List<int> inst, List<int> estilos)
        {
            cmd = new SqlCommand();
            //salvar configurações
            cmd.CommandText = @"
            update cadastro set nome = @nome where id = @id
            update cadastro set usuario = @usuario where id = @id
            update cadastro set email = @email where id = @id
            update pmusico set descriçao = @descriçaoM where id = @id
            update pmusico set regiao = @regiaoM where id = @id
            update pmusico set contato = @contato where id = @id
            update pmusico set publico = @publico where id = @id";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@descriçaoM", descriçaoM);
            cmd.Parameters.AddWithValue("@regiaoM", regiaoM);
            cmd.Parameters.AddWithValue("@contato", contato);
            cmd.Parameters.AddWithValue("@publico", publico);
            cmd.Parameters.AddWithValue("@id", Logar.userid);
            try
            {
                //abrir a conexão
                cmd.Connection = conexao.Conectar();
                //executar o comando
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Debug.WriteLine(e.Message);
                this.mensagem = e.Message;
            }
            finally
            {
                //fechar a conexão
                conexao.Desconectar();
            }
            this.mensagem = mefeito;
            //salvar lista de instrumentos
            AlterarInst(inst);
            //salvar lista de estilos
            AlterarEstilos(estilos);
            //se houver alteração na senha, alterar senha
            if (senha.Trim().Length > 0) AlterarSenha(senha);
        }
        void AlterarInst(List<int> inst)
        {
            //limpar a lista atual com os instrumentos do musico
            cmd = new SqlCommand();
            cmd.CommandText = "delete from instrumentosdosmusicos where musicoId = @musicoID";
            cmd.Parameters.AddWithValue("@musicoID", Logar.userid);
            try
            {
                //abrir a conexão
                cmd.Connection = conexao.Conectar();
                //executar o comando
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Debug.WriteLine(e.Message);
                this.mensagem = e.Message;
            }
            finally
            {
                //fechar a conexão
                conexao.Desconectar();
            }
            //repopular com os novos instrumentos informados
            foreach (int i in inst)
            {
                cmd = new SqlCommand();
                cmd.CommandText = @"insert into instrumentosdosmusicos values (@musicoID,@instrumentoID)";
                cmd.Parameters.AddWithValue("@musicoID", Logar.userid);
                cmd.Parameters.AddWithValue("@instrumentoID", i);
                try
                {
                    //abrir a conexão
                    cmd.Connection = conexao.Conectar();
                    //executar o comando
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.Message);
                    this.mensagem = e.Message;
                }
                finally
                {
                    //fechar a conexão
                    conexao.Desconectar();
                }
            }
        }
        void AlterarEstilos(List<int> estilos)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "delete from estilosdosmusicos where musicoId = @id";
            cmd.Parameters.AddWithValue("@id", Logar.userid);
            try
            {
                //abrir a conexão
                cmd.Connection = conexao.Conectar();
                //executar o comando
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Debug.WriteLine(e.Message);
                this.mensagem = e.Message;
            }
            finally
            {
                //fechar a conexão
                conexao.Desconectar();
            }
            foreach (int es in estilos)
            {
                cmd = new SqlCommand();
                cmd.CommandText = @"insert into estilosdosmusicos values (@musicoID,@estiloID)";
                cmd.Parameters.AddWithValue("@musicoID", Logar.userid);
                cmd.Parameters.AddWithValue("@estiloID", es);
                try
                {
                    //abrir a conexão
                    cmd.Connection = conexao.Conectar();
                    //executar o comando
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Debug.WriteLine(e.Message);
                    this.mensagem = e.Message;
                }
                finally
                {
                    //fechar a conexão
                    conexao.Desconectar();
                }
            }
        }
        void AlterarSenha(string senha)
        {
            cmd = new SqlCommand();
            //alterar a senha
            cmd.CommandText = @"update cadastro set senha = @senha where id = @id";
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@id", Logar.userid);
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                this.mensagem = e.Message;
                Debug.WriteLine(e.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }
        #endregion
    }
}
