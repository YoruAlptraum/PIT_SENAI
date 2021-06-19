using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace PIT_SENAI_Windows_Forms.DAL
{
    public class Eventos
    {
        public string mensagem;
        Conexao conexao = new Conexao();
        SqlCommand cmd;
        //Criar o DataAdapter
        SqlDataAdapter da;
        //Cria o DataTable.
        DataTable dt;

        public DataTable EventosDosOrganizadores()
        {
            cmd = new SqlCommand();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            //selecionar o nome, a descrição, a localizaçao e o contato
            //dos eventos do organizador selecionado
            cmd.CommandText = @"
            select e.nome,e.descriçao,e.localizaçao,e.contato,e.id
            from eventosdosorganizadores as eo
            inner join eventos as e
            on eo.idevento = e.id
            where eo.idOrganizador = @id
            ";
            cmd.Parameters.AddWithValue("@id",Logar.userid);

            try
            {
                cmd.Connection = conexao.Conectar();
                da.Fill(dt);
                conexao.Desconectar();

            }
            catch (SqlException Erro)
            {
                this.mensagem = Erro.ToString();
                Debug.WriteLine(Erro.ToString());
            }
            finally
            {
                conexao.Desconectar();
            }
            return dt;
        }
        public DataTable ListaDeEventos()
        {
            cmd = new SqlCommand();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            //seleciona o nome e descrição do evento
            //assim como o nome de usuario do organizador que publicou o evento
            //*adicionar a isso também o contato e a localização do evento
            cmd.CommandText = @"
            select e.nome,e.descriçao,e.localizaçao,e.contato,c.usuario,e.id
            from eventos as e
            inner join porganizador as po
            on e.idorganizador = po.id
            inner join cadastro as c
            on po.id = c.id
            ";
            try
            {
                cmd.Connection = conexao.Conectar();
                da.Fill(dt);
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
                Debug.WriteLine(e.ToString());
            }
            finally
            {
                conexao.Desconectar();
            }
            return dt;
        }
        public void CriarEvento(string evento, string descriçao, string localizaçao, string contato)
        {
            cmd = new SqlCommand();
            int idEv;
            //Inserir evento na tabela de eventos
            //procurar id do evento inserido
            cmd.CommandText = @"insert into eventos 
                                values (@evento,@descriçao,@id,@localizaçao,@contato)
                                select top(1) id from eventos order by id desc";
            cmd.Parameters.AddWithValue("@evento",evento);
            cmd.Parameters.AddWithValue("@descriçao", descriçao);
            cmd.Parameters.AddWithValue("@id", Logar.userid);
            cmd.Parameters.AddWithValue("@localizaçao", localizaçao);
            cmd.Parameters.AddWithValue("@contato", contato);
            try
            {
                cmd.Connection = conexao.Conectar();
                idEv = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch(SqlException e)
            {
                this.mensagem = e.ToString();
                Debug.WriteLine(e.ToString());
                return;
            }
            finally
            { 
                conexao.Desconectar();
            }

            //Inserir id do evento na tabela eventos dos organizadores
            cmd = new SqlCommand();
            cmd.CommandText = @"insert into eventosdosorganizadores
                                values (@idEvento,@idOrganizador)";
            cmd.Parameters.AddWithValue("@idEvento", idEv);
            cmd.Parameters.AddWithValue("@idOrganizador", Logar.userid);
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
                Debug.WriteLine(e.ToString());
                return;
            }
            finally
            {
                conexao.Desconectar();
            }
        }
        public void RemoverEvento(int id)
        {
            cmd = new SqlCommand();
            cmd.CommandText = @"delete from eventosdosorganizadores where idEvento = @id 
                                delete from eventos where id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                this.mensagem = e.ToString();
                Debug.WriteLine(e.ToString());
            }
            finally
            {
                conexao.Desconectar();
            }
        }
        public void AlterarEvento(int id,string nome, string descriçao, string localizaçao,string contato)
        {
            cmd = new SqlCommand();
            cmd.CommandText = @"update eventos 
                                set nome = @nome ,descriçao = @descriçao,
                                localizaçao = @localizaçao, contato = @contato
                                where id = @id";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@descriçao", descriçao);
            cmd.Parameters.AddWithValue("@localizaçao", localizaçao);
            cmd.Parameters.AddWithValue("@contato", contato);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
                Debug.WriteLine(e.ToString());
            }
            finally
            {
                conexao.Desconectar();
            }
        }
    }
}
