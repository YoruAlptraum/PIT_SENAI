using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIT_SENAI_Windows_Forms.Modelo;

namespace PIT_SENAI_Windows_Forms.Interfaces
{
    public partial class Principal : Form
    {
        Thread t1;
        bool ultimoPerfilMusico;
        string usuario;
        public Principal()
        {
            InitializeComponent();
            lblUser.Text = usuario = Controle.usuario;
            if (Controle.ultimoPerfilMusico) lblPerfilType.Text = "Músico";
            else lblPerfilType.Text = "Organizador";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirJanelaLogin);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }


        private void btnTrocarPerfil_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirJanelaPerfis);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirJanelaLogin()
        {
            Application.Run(new Login());
        }

        private void abrirJanelaPerfis()
        {
            Application.Run(new Perfis());
        }
    }
}
