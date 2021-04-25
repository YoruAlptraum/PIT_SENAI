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

        private void txt_cSenha_TextChanged(object sender, EventArgs e)
        {
            PWChar();
        }

        private void txt_cConfirmarSenha_TextChanged(object sender, EventArgs e)
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
                txt_cSenha.PasswordChar = (char)0;
                txt_cConfirmarSenha.PasswordChar = (char)0;
            }
            else
            {
                txt_cSenha.PasswordChar = '*';
                txt_cConfirmarSenha.PasswordChar = '*';
            }
        }

        private void btn_enviarCadastro_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();

            if (chk_deMaior.Checked && chk_termos.Checked && txt_cSenha.Text.Equals(txt_cConfirmarSenha.Text) &&
                !string.IsNullOrEmpty(txt_cNome.Text) && !string.IsNullOrEmpty(txt_cUser.Text) && 
                !string.IsNullOrEmpty(txt_cSenha.Text) && !string.IsNullOrEmpty(txt_cEmail.Text) && !string.IsNullOrEmpty(txt_cCPF.Text) )
            {
                controle.cadastrar(txt_cNome.Text,txt_cUser.Text,txt_cSenha.Text,txt_cEmail.Text,txt_cCPF.Text);
                MessageBox.Show(controle.mensagem);

                this.Close();
                t1 = new Thread(abrirJanelaLogin);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
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
    }
}
