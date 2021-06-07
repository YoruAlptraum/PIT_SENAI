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
    public partial class SubListaEventos : Form
    {
        Controle controle = new Controle();
        DataTable dt;
        public SubListaEventos()
        {
            InitializeComponent();
            //Atualizar a lista com todos os eventos ativos
            AtualizarlvwEventos();
        }
        public void AtualizarlvwEventos()
        {
            dt = new DataTable();
            //limpar lvw
            lvwEventos.Items.Clear();
            //pegar lista e passar lista para lvw
            dt = controle.ListaDeEventos();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for(int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                lvwEventos.Items.Add(item);
            }
        }
    }
}
