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
using PIT_SENAI_Windows_Forms.DAL;

namespace PIT_SENAI_Windows_Forms.Interfaces
{
    public partial class CadastroMusico : Form
    {
        DataTable dt;
        CadastrarMusico cm = new CadastrarMusico();

        Thread t1;
        public CadastroMusico()
        {
            InitializeComponent();
            btnRemoveInst.Enabled = btnRemoverEstilo.Enabled = false;
        }

        private void cmbInstrumento_Click(object sender, EventArgs e)
        {
            cmbInstrumento.Items.Clear();
            dt = cm.getInstrumentos();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    cmbInstrumento.Items.Add(dr[0]);
                }
            }
            else MessageBox.Show("No Rows");
            //cmbInstrumento.Items.Add(c);
        }

        private void cmbEstiloMusical_Click(object sender, EventArgs e)
        {
            cmbEstiloMusical.Items.Clear();
            dt = cm.getEstilos();
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

    }
}
