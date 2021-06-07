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
            //selecionar o nome e a descrição dos eventos de um organizador baseado no seu id
            cmd.CommandText = @"
            select e.nome,e.descriçao
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
            return dt;
        }
        public DataTable ListaDeEventos()
        {
            cmd = new SqlCommand();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            //seleciona o nome e descrição do evento
            //assim como o nome de usuario do organizador que publicou o evento
            cmd.CommandText = @"
            select e.nome,e.descriçao,c.usuario
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
                conexao.Desconectar();
            }
            catch (SqlException Erro)
            {
                this.mensagem = Erro.ToString();
                Debug.WriteLine(Erro.ToString());
            }
            return dt;
        }
    }
}
