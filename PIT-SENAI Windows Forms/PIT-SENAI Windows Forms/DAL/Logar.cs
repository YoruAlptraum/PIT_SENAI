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
    class Logar
    {
        public string mensagem = "";
        public string id,usuario;
        public bool acesso,firstLogin,ultimoPerfilMusico,temPerfilMusico,temPerfilOrganizador;

        Conexao conexao = new Conexao();
        static SqlCommand cmd = new SqlCommand();
        //Create a SqlDataAdapter for the table Cadastro
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        // Create the DataSet.
        DataTable dt = new DataTable("Cadastro");

        public bool verificarLogin(string email, string senha)
        {
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(senha))
            {
                cmd = new SqlCommand();
                da = new SqlDataAdapter(cmd);

                //procurar email e senha no banco de dados
                cmd.CommandText = "select id,usuario,firstLogin, ultimoPerfilMusico, temPerfilMusico, temPerfilOrganizador " +
                    "from cadastro where email = @email and senha = @senha";
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@email", email);

                try
                {
                    //o comando SQL é executado no adapter e guarda informações no systema atual
                    cmd.Connection = conexao.Conectar();
                    //Passas as informações no da (data adapter) para dt (data table)
                    da.Fill(dt);

                    if (dt.Rows.Count > 0) //se foi encontrado login e senha
                    {
                        //conferir se firstLogin no banco
                        if (BitConverter.ToBoolean((System.Byte[])dt.Rows[0]["firstLogin"],0)) this.firstLogin = true;
                        if (BitConverter.ToBoolean((System.Byte[])dt.Rows[0]["ultimoPerfilMusico"], 0)) this.ultimoPerfilMusico = true;
                        if (BitConverter.ToBoolean((System.Byte[])dt.Rows[0]["temPerfilMusico"], 0)) this.temPerfilMusico = true;
                        if (BitConverter.ToBoolean((System.Byte[])dt.Rows[0]["temPerfilOrganizador"], 0)) this.temPerfilOrganizador = true;
                        Debug.WriteLine((dt.Rows[0]["firstLogin"].ToString()));
                        //retorna o acesso como true
                        acesso = true;
                    }
                }
                catch (SqlException Erro)
                {
                    this.mensagem = Erro.ToString();
                    Debug.WriteLine(Erro.ToString());
                }
            }
            else this.mensagem = "Favor informar credenciais";

            return acesso;
        }

    }
}
