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

namespace PIT_SENAI_Windows_Forms
{
    public partial class Login : Form
    {
        //get bool firstLogin from database;
        private bool ultimoPerfilMusico = true;
        private bool firstLogin = true;


        Thread t1;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txt_login.Text, txt_password.Text);
            if (controle.mensagem.Equals(""))
            {

                if (controle.acesso)
                {
                    MessageBox.Show("Logado com Sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Enter();
                }
                else MessageBox.Show("Login não encontrado\n" +
                                    "Verifique credenciais", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show(controle.mensagem,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void Enter()
        {
            if (!firstLogin)
            {
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
