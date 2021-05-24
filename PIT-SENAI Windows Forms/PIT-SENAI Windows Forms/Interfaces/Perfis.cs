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
using PIT_SENAI_Windows_Forms.Interfaces;

namespace PIT_SENAI_Windows_Forms
{
    public partial class Perfis : Form
    {
        Thread t1;
        Controle c = new Controle();
        bool temPerfilOrganizador, temPerfilMusico;
        public Perfis()
        {
            InitializeComponent();
            this.temPerfilMusico = Controle.temPerfilMusico;
            this.temPerfilOrganizador = Controle.temPerfilOrganizador;
        }

        private void btnMusico_Click(object sender, EventArgs e)
        {
            if (temPerfilMusico)
            {
                //alterar ultimoPerfilMusico para true;
                c.AlterarUltimoPerfil(true);
                //abre Interface Principal com o Perfil Músico
                this.Close();
                t1 = new Thread(AbrirJanelaPrincipal);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();                
            }
            else
            {
                //abre a Janela de cadastro do Perfil Músico
                this.Close();
                t1 = new Thread(AbrirJanelaCadastroMusico);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
        }

        private void btnOrganizador_Click(object sender, EventArgs e)
        {
            if (temPerfilOrganizador)
            {
                //alterar ultimoPerfilMusico para false;
                c.AlterarUltimoPerfil(false);
                //abre Interface Principal com o Perfil Organizador
                this.Close();
                t1 = new Thread(AbrirJanelaPrincipal);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
            else
            {
                //abre a Janela de cadastro do Perfil Organizador
                this.Close();
                t1 = new Thread(AbrirJanelaCadastroOrganizador);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
        }

        private void AbrirJanelaPrincipal()
        {
            Application.Run(new Principal());
        }
        private void AbrirJanelaCadastroMusico()
        {
            Application.Run(new CadastroMusico());
        }

        private void AbrirJanelaCadastroOrganizador()
        {
            Application.Run(new CadastroOrganizador());
        }

    }
}
