using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIT_SENAI_Windows_Forms.DAL
{
    class Logar
    {
        Conexao conexao = new Conexao();
        public string mensagem = "";
        public bool acesso;
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public bool verificarLogin(string email, string senha)
        {
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(senha))
            {
                //procurar email e senha no banco de dados
                cmd.CommandText = "select * from cadastro where email = @email and senha = @senha";
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@email", email);

                try
                {
                    cmd.Connection = conexao.Conectar();

                    //executa o comando SQL e guarda informações no systema atual
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows) //se foi encontrado login e senha
                    {
                        acesso = true;
                    }
                }
                catch (SqlException)
                {
                    this.mensagem = "Erro com o banco de dados";
                }
            }
            else this.mensagem = "Favor informar credenciais";

            return acesso;
        }
    }
}
