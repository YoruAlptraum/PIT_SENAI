using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using PIT_SENAI_Windows_Forms.Modelo;

namespace PIT_SENAI_Windows_Forms.Interfaces
{
    public partial class CadastroMusico : Form
    {
        List<string> instrumentos = new List<string>();
        List<string> estilos = new List<string>();
        DataTable dt;
        Controle controle = new Controle();

        Thread t1;
        public CadastroMusico()
        {
            InitializeComponent();
            btnRemoveInst.Enabled = btnRemoverEstilo.Enabled = false;
        }

        private void cmbInstrumento_Click(object sender, EventArgs e)
        {
            cmbInstrumento.Items.Clear();
            dt = controle.getInstrumentos();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    cmbInstrumento.Items.Add(dr[0]);
                }
            }
            else MessageBox.Show("No Rows");
        }

        private void cmbEstiloMusical_Click(object sender, EventArgs e)
        {
            cmbEstiloMusical.Items.Clear();
            dt = controle.getEstilos();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    cmbEstiloMusical.Items.Add(dr[0]);
                }
            }
            else MessageBox.Show("No Rows");
        }

        private void llbVoltar_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirJanelaPerfis);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }


        private void AbrirJanelaPerfis()
        {
            Application.Run(new Perfis());
        }

        private void btnAddInst_Click(object sender, EventArgs e)
        {
            if(cmbInstrumento.Text.Length > 0)
            {
                bool tem = false;
                //adicionar instrumento na lista de instrumentos
                foreach (var i in instrumentos) if (i.Equals(cmbInstrumento.Text))
                    {
                        tem = true;
                        break;
                    }
                if (!tem) instrumentos.Add(cmbInstrumento.Text);
                //e então atualizar a list view
                UpdatelvwInstrumentos();
            }
        }

        private void btnAddEstilo_Click(object sender, EventArgs e)
        {
            if(cmbEstiloMusical.Text.Length > 0)
            {
                bool tem = false;
                foreach (var i in estilos) if (i.Equals(cmbEstiloMusical.Text))
                    {
                        tem = true;
                        break;
                    }
                if (!tem) estilos.Add(cmbEstiloMusical.Text);
                UpdatelvwEstilosMusicais();
            }
        }

        private void UpdatelvwInstrumentos()
        {
            lvwInstrumentos.Items.Clear();
            foreach(var i in instrumentos)
            {
                ListViewItem item = new ListViewItem(i);
                lvwInstrumentos.Items.Add(item);
            }
        }

        private void UpdatelvwEstilosMusicais()
        {
            lvwEstilosMusicais.Items.Clear();
            foreach(var i in estilos)
            {
                ListViewItem item = new ListViewItem(i);
                lvwEstilosMusicais.Items.Add(item);
            }
        }

        private void btnRemoveInst_Click(object sender, EventArgs e)
        {
            int index = instrumentos.FindIndex(i => i == lvwInstrumentos.SelectedItems[0].Text);
            instrumentos.RemoveAt(index);
            btnRemoveInst.Enabled = false;
            UpdatelvwInstrumentos();
        }
        private void btnRemoverEstilo_Click(object sender, EventArgs e)
        {
            int index = estilos.FindIndex(es => es == lvwEstilosMusicais.SelectedItems[0].Text);
            estilos.RemoveAt(index);
            btnRemoverEstilo.Enabled = false;
            UpdatelvwEstilosMusicais();
        }

        private void lvwInstrumentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwInstrumentos.SelectedItems.Count > 0)btnRemoveInst.Enabled = true;
            else btnRemoveInst.Enabled = false;
        }

        private void lvwEstilosMusicais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwEstilosMusicais.SelectedItems.Count > 0) btnRemoverEstilo.Enabled = true;
            else btnRemoverEstilo.Enabled = false;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            List<int> instrumentoID = new List<int>();
            List<int> estiloID = new List<int>();
            if (lvwInstrumentos.Items.Count > 0 && lvwEstilosMusicais.Items.Count > 0 &&
                txbRegiao.Text.Length > 0 && txbDescriçao.Text.Length > 0)
            {
                foreach (var i in instrumentos)
                {
                    dt = controle.getInstrumentos();
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            if (dr[0].Equals(i))
                            {
                                //se encontrar o instrumento na lista de instumentos
                                instrumentoID.Add(int.Parse(dr[1].ToString()));
                            }
                        }
                    }
                }
                foreach (var es in estilos)
                {
                    dt = controle.getEstilos();
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            if (dr[0].Equals(es))
                            {
                                //se encontrar o instrumento na lista de instumentos
                                estiloID.Add(int.Parse(dr[1].ToString()));
                            }
                        }
                    }
                }
                controle.cadastrarMusico(instrumentoID, estiloID, txbRegiao.Text, txbDescriçao.Text,txbContato.Text,!chkPublico.Checked);
                MessageBox.Show(controle.mensagem);
                if (controle.cadastrado)
                {
                    this.Close();
                    t1 = new Thread(abrirJanelaPrincipal);
                    t1.SetApartmentState(ApartmentState.STA);
                    t1.Start();
                }
            }
            else MessageBox.Show("Preencha todos os campos");
        }
        private void abrirJanelaPrincipal()
        {
            Application.Run(new Principal());
        }
    }
}
