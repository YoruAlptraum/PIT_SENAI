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
    public class CadastrarMusico
    {
        AlterarPerfil ap = new AlterarPerfil();
        public string cmMensagem = "";
        Conexao conexao = new Conexao();
        static SqlCommand cmd;
        //Create a SqlDataAdapter for the table Cadastro
        SqlDataAdapter da;
        //Create the DataSet.
        public static DataTable dt;
        public bool cadastrado,firstLogin,temPerfilMusico;

        public DataTable getInstrumentos()
        {
            cmd = new SqlCommand();
            da = new SqlDataAdapter(cmd);
            dt = new DataTable("Instrumento");

            cmd.CommandText = @"select * from instrumento";
            cmd.Connection = conexao.Conectar();
            da.Fill(dt);
            return dt;
        }

        public DataTable getEstilos()
        {
            cmd = new SqlCommand();
            da = new SqlDataAdapter(cmd);
            dt = new DataTable("EstiloMusical");

            cmd.CommandText = @"select * from estilomusical";
            cmd.Connection = conexao.Conectar();
            da.Fill(dt);
            return dt;
        }

        public void Cadastrar(List<int> instrumentosID, List<int> estilosID, string regiao, string descriçao)
        {
            try
            {
                //criar nova conexão
                cmd = new SqlCommand();

                cmd.CommandText = @"insert into pmusico values (@id,@descriçao,@regiao)
                                    update cadastro set firstLogin = 0 where id = @id
                                    update cadastro set ultimoperfilmusico = 1 where id = @id
                                    update cadastro set temperfilmusico =1 where id = @id";
                cmd.Parameters.AddWithValue("@id", Logar.userid);
                cmd.Parameters.AddWithValue("@descriçao", descriçao);
                cmd.Parameters.AddWithValue("@regiao", regiao);

                this.firstLogin = false;
                ap.AlterarUltimoPerfil(true);
                this.temPerfilMusico = true;

                //abrir a conexão
                cmd.Connection = conexao.Conectar();
                //executar o comando
                cmd.ExecuteNonQuery();
                //fechar a conexão
                conexao.Desconectar();

                foreach (var i in instrumentosID)
                {
                    cmd = new SqlCommand();
                    cmd.CommandText = @"insert into instrumentosdosmusicos values (@musicoID,@instrumentoID)";
                    cmd.Parameters.AddWithValue("@musicoID", Logar.userid);
                    cmd.Parameters.AddWithValue("@instrumentoID", i);

                    //abrir a conexão
                    cmd.Connection = conexao.Conectar();
                    //executar o comando
                    cmd.ExecuteNonQuery();
                    //fechar a conexão
                    conexao.Desconectar();
                }

                foreach (var es in estilosID)
                {
                    cmd = new SqlCommand();
                    cmd.CommandText = @"insert into estilosdosmusicos values (@musicoID,@estiloID)";
                    cmd.Parameters.AddWithValue("@musicoID", Logar.userid);
                    cmd.Parameters.AddWithValue("@estiloID", es);

                    //abrir a conexão
                    cmd.Connection = conexao.Conectar();
                    //executar o comando
                    cmd.ExecuteNonQuery();
                    //fechar a conexão
                    conexao.Desconectar();
                }
                this.cmMensagem = "Cadastro Realizado";
                this.cadastrado = true;
            }
            catch (SqlException Erro)
            {
                this.cmMensagem = Erro.ToString();
                Debug.WriteLine(Erro.ToString());
            }
        }
    }
}
