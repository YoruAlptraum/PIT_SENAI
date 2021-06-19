
namespace PIT_SENAI_Windows_Forms
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_enviarCadastro = new System.Windows.Forms.Button();
            this.txt_cNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbcSenha = new System.Windows.Forms.TextBox();
            this.txt_cCPF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_cEmail = new System.Windows.Forms.TextBox();
            this.chk_termos = new System.Windows.Forms.CheckBox();
            this.txbcConfirmarSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chk_showPassword = new System.Windows.Forms.CheckBox();
            this.llbVoltarAoLogin = new System.Windows.Forms.LinkLabel();
            this.lblConfirmSenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_enviarCadastro
            // 
            this.btn_enviarCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_enviarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviarCadastro.Location = new System.Drawing.Point(13, 368);
            this.btn_enviarCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.btn_enviarCadastro.Name = "btn_enviarCadastro";
            this.btn_enviarCadastro.Size = new System.Drawing.Size(100, 37);
            this.btn_enviarCadastro.TabIndex = 8;
            this.btn_enviarCadastro.Text = "Enviar";
            this.btn_enviarCadastro.UseVisualStyleBackColor = true;
            this.btn_enviarCadastro.Click += new System.EventHandler(this.btn_enviarCadastro_Click);
            // 
            // txt_cNome
            // 
            this.txt_cNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_cNome.Location = new System.Drawing.Point(114, 93);
            this.txt_cNome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cNome.Name = "txt_cNome";
            this.txt_cNome.Size = new System.Drawing.Size(555, 23);
            this.txt_cNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(479, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Preencha o formulário para realizar seu cadastro";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome de tela:";
            // 
            // txt_cUser
            // 
            this.txt_cUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_cUser.Location = new System.Drawing.Point(114, 125);
            this.txt_cUser.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cUser.Name = "txt_cUser";
            this.txt_cUser.Size = new System.Drawing.Size(555, 23);
            this.txt_cUser.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Senha:";
            // 
            // txbcSenha
            // 
            this.txbcSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbcSenha.Location = new System.Drawing.Point(114, 162);
            this.txbcSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txbcSenha.Name = "txbcSenha";
            this.txbcSenha.Size = new System.Drawing.Size(555, 23);
            this.txbcSenha.TabIndex = 3;
            this.txbcSenha.TextChanged += new System.EventHandler(this.txbcSenha_TextChanged);
            // 
            // txt_cCPF
            // 
            this.txt_cCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_cCPF.Location = new System.Drawing.Point(114, 308);
            this.txt_cCPF.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cCPF.Name = "txt_cCPF";
            this.txt_cCPF.Size = new System.Drawing.Size(555, 23);
            this.txt_cCPF.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 308);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "CPF:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 271);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "E-mail:";
            // 
            // txt_cEmail
            // 
            this.txt_cEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_cEmail.Location = new System.Drawing.Point(114, 271);
            this.txt_cEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cEmail.Name = "txt_cEmail";
            this.txt_cEmail.Size = new System.Drawing.Size(555, 23);
            this.txt_cEmail.TabIndex = 5;
            // 
            // chk_termos
            // 
            this.chk_termos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_termos.AutoSize = true;
            this.chk_termos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_termos.Location = new System.Drawing.Point(14, 339);
            this.chk_termos.Margin = new System.Windows.Forms.Padding(4);
            this.chk_termos.Name = "chk_termos";
            this.chk_termos.Size = new System.Drawing.Size(447, 21);
            this.chk_termos.TabIndex = 7;
            this.chk_termos.Text = "Li e aceito o Termo de Condições de Uso e Política de Privacidade";
            this.chk_termos.UseVisualStyleBackColor = true;
            // 
            // txbcConfirmarSenha
            // 
            this.txbcConfirmarSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbcConfirmarSenha.Location = new System.Drawing.Point(114, 211);
            this.txbcConfirmarSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txbcConfirmarSenha.Name = "txbcConfirmarSenha";
            this.txbcConfirmarSenha.Size = new System.Drawing.Size(555, 23);
            this.txbcConfirmarSenha.TabIndex = 4;
            this.txbcConfirmarSenha.TextChanged += new System.EventHandler(this.txbcConfirmarSenha_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 34);
            this.label5.TabIndex = 16;
            this.label5.Text = "Confirme \r\na Senha:";
            // 
            // chk_showPassword
            // 
            this.chk_showPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chk_showPassword.AutoSize = true;
            this.chk_showPassword.Location = new System.Drawing.Point(528, 243);
            this.chk_showPassword.Margin = new System.Windows.Forms.Padding(4);
            this.chk_showPassword.Name = "chk_showPassword";
            this.chk_showPassword.Size = new System.Drawing.Size(137, 20);
            this.chk_showPassword.TabIndex = 18;
            this.chk_showPassword.Text = "Show Passwords";
            this.chk_showPassword.UseVisualStyleBackColor = true;
            this.chk_showPassword.CheckedChanged += new System.EventHandler(this.chk_showPassword_CheckedChanged);
            // 
            // llbVoltarAoLogin
            // 
            this.llbVoltarAoLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.llbVoltarAoLogin.AutoSize = true;
            this.llbVoltarAoLogin.Location = new System.Drawing.Point(538, 486);
            this.llbVoltarAoLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbVoltarAoLogin.Name = "llbVoltarAoLogin";
            this.llbVoltarAoLogin.Size = new System.Drawing.Size(146, 16);
            this.llbVoltarAoLogin.TabIndex = 19;
            this.llbVoltarAoLogin.TabStop = true;
            this.llbVoltarAoLogin.Text = "Voltar a tela de login";
            this.llbVoltarAoLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDeVoltaAoLogin_LinkClicked);
            // 
            // lblConfirmSenha
            // 
            this.lblConfirmSenha.AutoSize = true;
            this.lblConfirmSenha.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmSenha.Location = new System.Drawing.Point(111, 238);
            this.lblConfirmSenha.Name = "lblConfirmSenha";
            this.lblConfirmSenha.Size = new System.Drawing.Size(0, 16);
            this.lblConfirmSenha.TabIndex = 20;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 513);
            this.Controls.Add(this.lblConfirmSenha);
            this.Controls.Add(this.llbVoltarAoLogin);
            this.Controls.Add(this.chk_showPassword);
            this.Controls.Add(this.txbcConfirmarSenha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chk_termos);
            this.Controls.Add(this.txt_cEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_cCPF);
            this.Controls.Add(this.txbcSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_cUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cNome);
            this.Controls.Add(this.btn_enviarCadastro);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_enviarCadastro;
        private System.Windows.Forms.TextBox txt_cNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbcSenha;
        private System.Windows.Forms.TextBox txt_cCPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_cEmail;
        private System.Windows.Forms.CheckBox chk_termos;
        private System.Windows.Forms.TextBox txbcConfirmarSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk_showPassword;
        private System.Windows.Forms.LinkLabel llbVoltarAoLogin;
        private System.Windows.Forms.Label lblConfirmSenha;
    }
}