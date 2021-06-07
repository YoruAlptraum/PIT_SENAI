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
        bool perfilM;
        public Principal()
        {
            InitializeComponent();
            lblUser.Text = Controle.usuario;
            perfilM = Controle.ultimoPerfilMusico;
            if (perfilM)
            {
                lblPerfilType.Text = "Músico";
                btnListar.Text = "Procurar Eventos";
            }
            else
            {
                lblPerfilType.Text = "Organizador";
                btnListar.Text = "Procurar Musicos";
                btnMeusEventos.Enabled = true;
            }
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
        //abrir um formulario secundario dentro do painel usar 'OpenChild<'nome do formulario'>();'
        void OpenChild<ChildForm>() where ChildForm : Form, new()
        {
            Form formulario;
            //procura na coleção de forms
            formulario = pnlPrincipal.Controls.OfType<ChildForm>().FirstOrDefault();
            //se não existe uma instancia do formulario
            if(formulario == null)
            {
                //configurações do formulario secundario
                formulario = new ChildForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                //abrir o formulario secundario no painel
                pnlPrincipal.Controls.Add(formulario);
                pnlPrincipal.Tag = formulario;
                formulario.Show();
            }
            formulario.BringToFront();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (perfilM)
            {
                OpenChild<SubListaEventos>();
            }
            else
            {
                //OpenChild<SubListaMusicos>();
                MessageBox.Show("not implemented");
            }
        }
        private void btnMeusEventos_Click(object sender, EventArgs e)
        {
            OpenChild<SubEventosDosOrganizadores>();
        }
    }
}
