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
    public partial class SubEventosDosOrganizadores : Form
    {
        Controle ctrl = new Controle();
        DataTable dt;
        public SubEventosDosOrganizadores()
        {
            InitializeComponent();
            //buscar no banco de dados os eventos do organizador baseado em seu id
            AtualizarlvwEventos();
            btnDeletarEvento.Enabled = btnAlterarEvento.Enabled = false;
        }

        public void AtualizarlvwEventos()
        {
            dt = new DataTable();
            lvwEventos.Items.Clear();
            //realizar o comando para procurar e
            dt = ctrl.EventosDosOrganizadores();
            //receber uma dataTable dos eventos com o id do organizador
            //popular a lvw com os eventos
            foreach (DataRow r in dt.Rows)
            {
                ListViewItem item = new ListViewItem(r[0].ToString());
                for(int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(r[i].ToString());
                }
                lvwEventos.Items.Add(item);
            }

        }

        private void btnCriarEvento_Click(object sender, EventArgs e)
        {
            ctrl.CriarEvento(txbEvento.Text,txbDescriçao.Text,txbLocalizaçao.Text,txbContato.Text);
            AtualizarlvwEventos();
        }

        private void btnDeletarEvento_Click(object sender, EventArgs e)
        {
            ctrl.RemoverEvento(GetEvento());
            AtualizarlvwEventos();
        }

        private void btnAlterarEvento_Click(object sender, EventArgs e)
        {
            ctrl.AlterarEvento(GetEvento(), txbEvento.Text, txbDescriçao.Text, txbLocalizaçao.Text, txbContato.Text);
            AtualizarlvwEventos();
        }
        private int GetEvento()
        {
            int idEv, i = 0;

            //receber index do evento selecionado na lvw
            if (lvwEventos.SelectedItems.Count > 0)
            {
                i = lvwEventos.Items.IndexOf(lvwEventos.SelectedItems[0]);
            }
            //passar o index da lvw para id
            idEv = Convert.ToInt32(lvwEventos.Items[i].SubItems[4].Text);
            return idEv;
        }

        private void lvwEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = -1;
            if (lvwEventos.SelectedItems.Count > 0)
            {
                i = lvwEventos.Items.IndexOf(lvwEventos.SelectedItems[0]);
                btnAlterarEvento.Enabled = btnDeletarEvento.Enabled = true;
            }
            else btnAlterarEvento.Enabled = btnDeletarEvento.Enabled = false;

            if (i == -1)
            {
                txbEvento.Text = txbDescriçao.Text = txbLocalizaçao.Text = txbContato.Text = "";                
            }
            else
            {
                txbEvento.Text = lvwEventos.Items[i].SubItems[0].Text;
                txbDescriçao.Text = lvwEventos.Items[i].SubItems[1].Text;
                txbLocalizaçao.Text = lvwEventos.Items[i].SubItems[2].Text;
                txbContato.Text = lvwEventos.Items[i].SubItems[3].Text;
            }
        }
    }
}
