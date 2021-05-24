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
    public partial class CadastroOrganizador : Form
    {
        Thread t1;
        Controle controle = new Controle();

        public CadastroOrganizador()
        {
            InitializeComponent();
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

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(txbDescriçao.Text.Length > 0 && txbRegiao.Text.Length > 0)
            {
                controle.cadastrarOrganizador(txbRegiao.Text,txbDescriçao.Text);
                MessageBox.Show(controle.mensagem);
                if (controle.cadastrado)
                {
                    this.Close();
                    t1 = new Thread(abrirJanelaPrincipal);
                    t1.SetApartmentState(ApartmentState.STA);
                    t1.Start();
                }
            }
        }
        private void abrirJanelaPrincipal()
        {
            Application.Run(new Principal());
        }
    }
}
