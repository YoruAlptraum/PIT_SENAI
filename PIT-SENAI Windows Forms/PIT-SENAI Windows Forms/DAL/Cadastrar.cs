using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PIT_SENAI_Windows_Forms
{
    public class Cadastrar
    {
        Conexao conexao;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public string mensagem;
        string txt;


        public Cadastrar(string nome, string usuario, string senha, string email, string cpf)
        {
            //procurar se os campos unicos ja existem no banco de dados
            //alterar a mensagem dependendo do erro
            try
            {
                for(int i = 0; i < 3; i++)
                {
                    conexao = new Conexao();
                    cmd = new SqlCommand();
                    da = new SqlDataAdapter(cmd);
                    dt = new DataTable("Selects");
                    switch (i)
                    {
                        case 0: txt = "Usuario ja existe"; SelectUsuario(usuario); break;
                        case 1: txt = "Email ja cadastrado"; SelectEmail(email);break;
                        case 2: txt = "CPF ja cadastrado"; SelectCPF(cpf);break;
                    }
                    try
                    {
                        cmd.Connection = conexao.Conectar();
                        da.Fill(dt);
                        conexao.Desconectar();
                        if (dt.Rows.Count > 0)
                        {
                            this.mensagem = txt;
                            return;
                        }
                    }
                    catch(Exception e)
                    {
                        this.mensagem = e.ToString();
                        Debug.WriteLine(e);
                        return;
                    }
                }


                conexao = new Conexao();
                cmd = new SqlCommand();
                //Comando Sql (SqlCommand) -- insert, update, delete --
                //usar parenteses com as colunas que irá inserir caso não preencha todos os campos da tabela,
                //do contrario, não é necessário.
                cmd.CommandText = "insert into cadastro (nome, usuario, senha, email, cpf, " +
                    "firstLogin,ultimoPerfilMusico,temPerfilMusico,temPerfilOrganizador) " +
                    "values(@nome,@usuario,@senha,@email,@cpf,1,1,0,0)";

                //parâmetros
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@cpf", cpf);

                //concectar com o banco -- Conectar
                try
                {
                    //receber endereço do bando de dados onde o comando será executado
                    cmd.Connection = conexao.Conectar();

                    //apenas executa o Comando Sql, não guarda informações
                    cmd.ExecuteNonQuery();

                    //desconectar o banco de dados -- Desconectar
                    conexao.Desconectar();

                    //mostrar mensagem de erro ou sucesso -- variavel
                    this.mensagem = "Cadastro realizado com sucesso!";
                }
                catch (SqlException e)
                {
                    this.mensagem = "Erro ao se conectar ao banco de dados";
                    Debug.WriteLine(e.Message);
                }
            }
            catch(Exception e)
            {
                this.mensagem = e.Message;
            }
        }

        void SelectUsuario(string usuario)
        {
            cmd.CommandText = "select usuario from cadastro " +
            "where usuario = @usuario";
            cmd.Parameters.AddWithValue("@usuario", usuario);
        }
        void SelectEmail(string email)
        {
            cmd.CommandText = "select email from cadastro " +
            "where email = @email";
            cmd.Parameters.AddWithValue("@email", email);
        }
        void SelectCPF(string cpf)
        {
            cmd.CommandText = "select cpf from cadastro " +
            "where cpf = @cpf";
            cmd.Parameters.AddWithValue("@cpf", cpf);
        }
    }
}
