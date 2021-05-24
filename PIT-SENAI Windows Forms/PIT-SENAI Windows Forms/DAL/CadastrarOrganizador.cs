using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PIT_SENAI_Windows_Forms.DAL
{
    class CadastrarOrganizador
    {
        public string coMensagem = "";
        public bool cadastrado,firstLogin,temPerfilOrganizador;
        Conexao conexao = new Conexao();
        static SqlCommand cmd;
        AlterarPerfil ap = new AlterarPerfil();

        public void Cadastrar(string regiao, string descriçao)
        {
            try
            {
                //criar nova conexão
                cmd = new SqlCommand();

                cmd.CommandText = @"insert into porganizador values (@id,@descriçao,@regiao)
                                    update cadastro set firstLogin = 0 where id = @id
                                    update cadastro set ultimoperfilmusico = 0 where id = @id
                                    update cadastro set temperfilorganizador =1 where id = @id";
                cmd.Parameters.AddWithValue("@id", Logar.userid);
                cmd.Parameters.AddWithValue("@descriçao", descriçao);
                cmd.Parameters.AddWithValue("@regiao", regiao);

                this.firstLogin = false;
                ap.AlterarUltimoPerfil(false);
                this.temPerfilOrganizador = true;

                //abrir a conexão
                cmd.Connection = conexao.Conectar();
                //executar o comando
                cmd.ExecuteNonQuery();
                //fechar a conexão
                conexao.Desconectar();

                this.coMensagem = "Cadastro Realizado";
                this.cadastrado = true;
            }
            catch (SqlException Erro)
            {
                this.coMensagem = Erro.ToString();
                Debug.WriteLine(Erro.ToString());
            }
        }
    }
}
