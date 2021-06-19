using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace PIT_SENAI_Windows_Forms.DAL
{
    class Musicos
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd;
        //Criar o DataAdapter
        SqlDataAdapter da;
        //Cria o DataTable.
        DataTable dt;
        public string mensagem = "";
        public DataTable ListaDeMusicos()
        {
            cmd = new SqlCommand();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);

            cmd.CommandText = @"
            select c.nome, m.descriçao, m.regiao, m.contato
            from cadastro as c
            inner join pmusico as m
            on c.id = m.id
            where publico = 1";

            try
            {
                cmd.Connection = conexao.Conectar();
                da.Fill(dt);
            }
            catch(SqlException e)
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
    }
}
