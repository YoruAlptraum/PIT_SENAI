
namespace PIT_SENAI_Windows_Forms
{
    partial class Login
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
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbl_noMatches = new System.Windows.Forms.Label();
            this.chk_showPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_login
            // 
            this.txt_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_login.Location = new System.Drawing.Point(38, 58);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(163, 20);
            this.txt_login.TabIndex = 0;
            // 
            // txt_password
            // 
            this.txt_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_password.Location = new System.Drawing.Point(38, 97);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(163, 20);
            this.txt_password.TabIndex = 1;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login.Location = new System.Drawing.Point(126, 146);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 31);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseMnemonic = false;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(123, 200);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(109, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cadastrar nova conta";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbl_noMatches
            // 
            this.lbl_noMatches.AutoSize = true;
            this.lbl_noMatches.Location = new System.Drawing.Point(35, 161);
            this.lbl_noMatches.Name = "lbl_noMatches";
            this.lbl_noMatches.Size = new System.Drawing.Size(0, 13);
            this.lbl_noMatches.TabIndex = 6;
            // 
            // chk_showPassword
            // 
            this.chk_showPassword.AutoSize = true;
            this.chk_showPassword.Location = new System.Drawing.Point(100, 123);
            this.chk_showPassword.Name = "chk_showPassword";
            this.chk_showPassword.Size = new System.Drawing.Size(101, 17);
            this.chk_showPassword.TabIndex = 7;
            this.chk_showPassword.Text = "Show password";
            this.chk_showPassword.UseVisualStyleBackColor = true;
            this.chk_showPassword.CheckedChanged += new System.EventHandler(this.chk_showPassword_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 222);
            this.Controls.Add(this.chk_showPassword);
            this.Controls.Add(this.lbl_noMatches);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbl_noMatches;
        private System.Windows.Forms.CheckBox chk_showPassword;
    }
}

