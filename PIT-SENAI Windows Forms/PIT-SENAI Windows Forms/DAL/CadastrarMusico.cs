using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PIT_SENAI_Windows_Forms.DAL
{
    public class CadastrarMusico
    {
        Conexao conexao = new Conexao();
        static SqlCommand cmd;
        //Create a SqlDataAdapter for the table Cadastro
        SqlDataAdapter da;
        //Create the DataSet.
        public static DataTable dt;

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
    }
}
