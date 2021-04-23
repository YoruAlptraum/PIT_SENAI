
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
            this.txt_cSenha = new System.Windows.Forms.TextBox();
            this.txt_cCPF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chk_deMaior = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_cEmail = new System.Windows.Forms.TextBox();
            this.chk_termos = new System.Windows.Forms.CheckBox();
            this.txt_cConfirmarSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chk_showPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_enviarCadastro
            // 
            this.btn_enviarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviarCadastro.Location = new System.Drawing.Point(16, 338);
            this.btn_enviarCadastro.Name = "btn_enviarCadastro";
            this.btn_enviarCadastro.Size = new System.Drawing.Size(75, 30);
            this.btn_enviarCadastro.TabIndex = 0;
            this.btn_enviarCadastro.Text = "Enviar";
            this.btn_enviarCadastro.UseVisualStyleBackColor = true;
            this.btn_enviarCadastro.Click += new System.EventHandler(this.btn_enviarCadastro_Click);
            // 
            // txt_cNome
            // 
            this.txt_cNome.Location = new System.Drawing.Point(68, 60);
            this.txt_cNome.Name = "txt_cNome";
            this.txt_cNome.Size = new System.Drawing.Size(493, 20);
            this.txt_cNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(479, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Preencha o formulário para realizar seu cadastro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "User:";
            // 
            // txt_cUser
            // 
            this.txt_cUser.Location = new System.Drawing.Point(61, 90);
            this.txt_cUser.Name = "txt_cUser";
            this.txt_cUser.Size = new System.Drawing.Size(500, 20);
            this.txt_cUser.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Senha:";
            // 
            // txt_cSenha
            // 
            this.txt_cSenha.Location = new System.Drawing.Point(72, 120);
            this.txt_cSenha.Name = "txt_cSenha";
            this.txt_cSenha.Size = new System.Drawing.Size(489, 20);
            this.txt_cSenha.TabIndex = 7;
            this.txt_cSenha.TextChanged += new System.EventHandler(this.txt_cSenha_TextChanged);
            // 
            // txt_cCPF
            // 
            this.txt_cCPF.Location = new System.Drawing.Point(57, 240);
            this.txt_cCPF.Name = "txt_cCPF";
            this.txt_cCPF.Size = new System.Drawing.Size(504, 20);
            this.txt_cCPF.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "CPF:";
            // 
            // chk_deMaior
            // 
            this.chk_deMaior.AutoSize = true;
            this.chk_deMaior.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_deMaior.Location = new System.Drawing.Point(16, 284);
            this.chk_deMaior.Name = "chk_deMaior";
            this.chk_deMaior.Size = new System.Drawing.Size(150, 21);
            this.chk_deMaior.TabIndex = 11;
            this.chk_deMaior.Text = "Sou maior de idade";
            this.chk_deMaior.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "E-mail:";
            // 
            // txt_cEmail
            // 
            this.txt_cEmail.Location = new System.Drawing.Point(70, 210);
            this.txt_cEmail.Name = "txt_cEmail";
            this.txt_cEmail.Size = new System.Drawing.Size(491, 20);
            this.txt_cEmail.TabIndex = 13;
            // 
            // chk_termos
            // 
            this.chk_termos.AutoSize = true;
            this.chk_termos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_termos.Location = new System.Drawing.Point(16, 311);
            this.chk_termos.Name = "chk_termos";
            this.chk_termos.Size = new System.Drawing.Size(447, 21);
            this.chk_termos.TabIndex = 15;
            this.chk_termos.Text = "Li e aceito o Termo de Condições de Uso e Política de Privacidade";
            this.chk_termos.UseVisualStyleBackColor = true;
            // 
            // txt_cConfirmarSenha
            // 
            this.txt_cConfirmarSenha.Location = new System.Drawing.Point(144, 150);
            this.txt_cConfirmarSenha.Name = "txt_cConfirmarSenha";
            this.txt_cConfirmarSenha.Size = new System.Drawing.Size(417, 20);
            this.txt_cConfirmarSenha.TabIndex = 17;
            this.txt_cConfirmarSenha.TextChanged += new System.EventHandler(this.txt_cConfirmarSenha_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Confirme a Senha:";
            // 
            // chk_showPassword
            // 
            this.chk_showPassword.AutoSize = true;
            this.chk_showPassword.Location = new System.Drawing.Point(454, 180);
            this.chk_showPassword.Name = "chk_showPassword";
            this.chk_showPassword.Size = new System.Drawing.Size(107, 17);
            this.chk_showPassword.TabIndex = 18;
            this.chk_showPassword.Text = "Show Passwords";
            this.chk_showPassword.UseVisualStyleBackColor = true;
            this.chk_showPassword.CheckedChanged += new System.EventHandler(this.chk_showPassword_CheckedChanged);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 405);
            this.Controls.Add(this.chk_showPassword);
            this.Controls.Add(this.txt_cConfirmarSenha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chk_termos);
            this.Controls.Add(this.txt_cEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chk_deMaior);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_cCPF);
            this.Controls.Add(this.txt_cSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_cUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cNome);
            this.Controls.Add(this.btn_enviarCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Cadastro";
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
        private System.Windows.Forms.TextBox txt_cSenha;
        private System.Windows.Forms.TextBox txt_cCPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chk_deMaior;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_cEmail;
        private System.Windows.Forms.CheckBox chk_termos;
        private System.Windows.Forms.TextBox txt_cConfirmarSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk_showPassword;
    }
}