using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIT_SENAI_Windows_Forms
{
    public class Cadastrar
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;
        

        public Cadastrar(String nome, String usuario, String senha, String email, String cpf)
        {
            //Comando Sql (SqlCommand) -- insert, update, delete --
            //usar parenteses caso não preencha todos os campos da tabela, do contrario, não é necessário.
            cmd.CommandText = "insert into cadastro (nome, usuario, senha, email, cpf, firstLogin) " +
                "values(@nome,@usuario,@senha,@email,@cpf,1)";

            //parâmetros
            cmd.Parameters.AddWithValue("@nome",nome);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@cpf", cpf);

            //concectar com o banco -- Conectar
            try
            {
                //receber endereço do bando de dados onde o comando será executado
                cmd.Connection = conexao.Conectar();

                //executar o Comando Sql
                cmd.ExecuteNonQuery();

                //desconectar o banco de dados -- Desconectar
                conexao.Desconectar();

                //mostrar mensagem de erro ou sucesso -- variavel
                this.mensagem = "Cadastro enviado";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro se conectar ao banco de dados";
            }

        }
    }
}
