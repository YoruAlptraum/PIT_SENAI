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
using System.Threading;

namespace PIT_SENAI_Windows_Forms
{
    public partial class Cadastro : Form
    {
        Thread t1;

        public Cadastro()
        {
            InitializeComponent();
        }

        private void txbcSenha_TextChanged(object sender, EventArgs e)
        {
            PWChar();
        }

        private void txbcConfirmarSenha_TextChanged(object sender, EventArgs e)
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
                txbcSenha.PasswordChar = (char)0;
                txbcConfirmarSenha.PasswordChar = (char)0;
            }
            else
            {
                txbcSenha.PasswordChar = '*';
                txbcConfirmarSenha.PasswordChar = '*';
            }
            if (txbcConfirmarSenha.Text.Equals(txbcSenha.Text))
            {
                txbcConfirmarSenha.ForeColor = Color.Black;
                lblConfirmSenha.Text = "";
            }
            else
            {
                txbcConfirmarSenha.ForeColor = Color.Red;
                lblConfirmSenha.ForeColor = Color.Red;
                lblConfirmSenha.Text = "A senha e a confirmação de senha precisam ser iguais";
            }
        }


        private void btn_enviarCadastro_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();

            if (chk_termos.Checked && txbcSenha.Text.Equals(txbcConfirmarSenha.Text) &&
                !string.IsNullOrEmpty(txt_cNome.Text) && !string.IsNullOrEmpty(txt_cUser.Text) && 
                !string.IsNullOrEmpty(txbcSenha.Text) && !string.IsNullOrEmpty(txt_cEmail.Text) && !string.IsNullOrEmpty(txt_cCPF.Text) )
            {
                controle.cadastrar(txt_cNome.Text,txt_cUser.Text,txbcSenha.Text,txt_cEmail.Text,txt_cCPF.Text);
                MessageBox.Show(controle.mensagem);

                if (controle.mensagem.Equals("Cadastro realizado com sucesso!"))
                {
                    this.Close();
                    t1 = new Thread(abrirJanelaLogin);
                    t1.SetApartmentState(ApartmentState.STA);
                    t1.Start();
                }
            }
            else
            {
                MessageBox.Show("todos os campos precisam estar preenchidos e senha deve ser igual a confirmação");
            }
        }

        private void abrirJanelaLogin()
        {
            Application.Run(new Login());
        }

        private void llbDeVoltaAoLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirJanelaLogin);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
    }
}
