using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIT_SENAI_Windows_Forms
{
    public partial class Cadastro : Form
    {
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
            Cadastrar cadastrar = new Cadastrar(txt_cNome.Text,txt_cUser.Text,txt_cSenha.Text,txt_cEmail.Text,txt_cCPF.Text);
            MessageBox.Show(cadastrar.mensagem);
        }
    }
}
