using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIT_SENAI_Windows_Forms.DAL
{
    class AlterarPerfil
    {
        static public string mensagem = "";
        public static bool ultimoPerfilMusico;
        Conexao conexao = new Conexao();
        static SqlCommand cmd;

        //alterar o ultimoPerfilMusico para true;
        public void AlterarUltimoPerfil(bool upm)
        {
            try
            {
                int n;
                //criar nova conexão
                cmd = new SqlCommand();

                if (upm) n = 1;
                else n = 0;

                cmd.CommandText = @"update cadastro set ultimoperfilmusico = @n where id = @id";
                cmd.Parameters.AddWithValue("@id", Logar.userid);
                cmd.Parameters.AddWithValue("@n", n);
                ultimoPerfilMusico = upm;

                //abrir a conexão
                cmd.Connection = conexao.Conectar();
                //executar o comando
                cmd.ExecuteNonQuery();
                //fechar a conexão
                conexao.Desconectar();

                mensagem = "Alteração realizada";
            }
            catch (SqlException Erro)
            {
                mensagem = Erro.ToString();
                Debug.WriteLine(Erro.ToString());
            }
        }
    }
}
