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

namespace PIT_SENAI_Windows_Forms
{
    public partial class Login : Form
    {
        //get bool firstLogin from database;
        private bool firstLogin,ultimoPerfilMusico = true;
        private bool perfilAtualMusico;


        Thread t1;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (CheckLogin())
            {
                Enter();
            }
            else
            {
                lbl_noMatches.Text = "Login or password doesn't match";
            }
        }

        private bool CheckLogin()
        {
            //check database, if username and password check, return true, else, return false
            if (true)
            {
                return true;
            }
            else return false;
        }

        private void Enter()
        {
            if (firstLogin)
            {
                this.Close();
                t1 = new Thread(abrirJanelaPerfis);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
            else
            {
                if (ultimoPerfilMusico)
                {
                    perfilAtualMusico = true;
                }
                else perfilAtualMusico = false;
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
