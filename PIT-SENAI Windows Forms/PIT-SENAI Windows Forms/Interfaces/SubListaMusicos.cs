using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIT_SENAI_Windows_Forms.Modelo;

namespace PIT_SENAI_Windows_Forms.Interfaces
{
    public partial class SubListaMusicos : Form
    {
        DataTable dt;
        Controle ctrl = new Controle();
        public SubListaMusicos()
        {
            InitializeComponent();
            AtualizarlvwMusicos();
        }
        public void AtualizarlvwMusicos()
        {
            //receber dt do banco de dados
            dt = new DataTable();
            lvwMusicos.Items.Clear();
            dt = ctrl.ListaDeMusicos();
            //pupular a lvwMusicos
            foreach(DataRow r in dt.Rows)
            {
                ListViewItem item = new ListViewItem(r[0].ToString());
                for(int i = 1; i<dt.Columns.Count; i++)
                {
                    item.SubItems.Add(r[i].ToString());
                }
                lvwMusicos.Items.Add(item);
            }
        }
    }
}
