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
using PIT_SENAI_Windows_Forms.Interfaces;
using PIT_SENAI_Windows_Forms.Modelo;
using System.Data.SqlClient;

namespace PIT_SENAI_Windows_Forms
{
    public partial class Login : Form
    {
        Controle controle = new Controle();

        Thread t1;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            controle.acessar(txt_login.Text, txt_password.Text);

            if (controle.mensagem.Equals(""))
            {
                if (controle.acesso)
                {
                    Entrar();
                }
                else MessageBox.Show("Login não encontrado\n" +
                                    "Verifique credenciais", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show(controle.mensagem,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void Entrar()
        {
            bool firstLogin = controle.firstLogin;

            if (firstLogin)
            {
                //Janela Perfis
                this.Close();
                t1 = new Thread(abrirJanelaPerfis);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
            else
            {
                //Janela Principal
                this.Close();
                t1 = new Thread(abrirJanelaPrincipal);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirJanelaCadastro);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirJanelaCadastro()
        {
            Application.Run(new Cadastro());
        }

        private void abrirJanelaPerfis()
        {
            Application.Run(new Perfis());
        }

        private void abrirJanelaPrincipal()
        {
            Application.Run(new Principal());
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            PWChar();
        }

        private void chk_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            PWChar();
        }

        private void PWChar()
        {
            if (chk_showPassword.Checked)
            {
                txt_password.PasswordChar = (char)0;
            }
            else txt_password.PasswordChar = '*';
        }
    }
}
