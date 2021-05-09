using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIT_SENAI_Windows_Forms.DAL
{
    class Logar
    {
        public string mensagem = "";
        public string id,usuario;
        public bool acesso,firstLogin;

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public bool verificarLogin(string email, string senha)
        {

            //Create a SqlDataAdapter for the Suppliers table.
            SqlDataAdapter adapter = new SqlDataAdapter();
            // Fill the DataSet.
            DataSet dataSet = new DataSet("Cadastro");
            adapter.Fill(dataSet);


            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(senha))
            {
                //procurar email e senha no banco de dados
                cmd.CommandText = "select id,usuario,firstLogin from cadastro where email = @email and senha = @senha";
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@email", email);

                try
                {
                    cmd.Connection = conexao.Conectar();

                    //executa o comando SQL e guarda informações no systema atual
                    dr = cmd.ExecuteReader();
                   

                    if (dr.HasRows) //se foi encontrado login e senha
                    {
                        while (dr.Read())
                        {
                            id = dr.GetValue(0).ToString();
                            usuario = dr.GetString(1);
                            firstLogin = dr.GetBoolean(2);
                        }

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
