
namespace PIT_SENAI_Windows_Forms.Interfaces
{
    partial class Principal
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
            this.btnProfileImage = new System.Windows.Forms.Button();
            this.lblPerfilType = new System.Windows.Forms.Label();
            this.btnMeusEventos = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnTrocarPerfil = new System.Windows.Forms.Button();
            this.btnConf = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProfileImage
            // 
            this.btnProfileImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProfileImage.FlatAppearance.BorderSize = 0;
            this.btnProfileImage.Location = new System.Drawing.Point(0, 0);
            this.btnProfileImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnProfileImage.Name = "btnProfileImage";
            this.btnProfileImage.Size = new System.Drawing.Size(69, 69);
            this.btnProfileImage.TabIndex = 0;
            this.btnProfileImage.UseVisualStyleBackColor = true;
            // 
            // lblPerfilType
            // 
            this.lblPerfilType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPerfilType.AutoSize = true;
            this.lblPerfilType.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.lblPerfilType.Location = new System.Drawing.Point(70, 49);
            this.lblPerfilType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerfilType.Name = "lblPerfilType";
            this.lblPerfilType.Size = new System.Drawing.Size(94, 16);
            this.lblPerfilType.TabIndex = 5;
            this.lblPerfilType.Text = "Tipo do Perfil";
            this.lblPerfilType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMeusEventos
            // 
            this.btnMeusEventos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMeusEventos.Enabled = false;
            this.btnMeusEventos.FlatAppearance.BorderSize = 0;
            this.btnMeusEventos.Location = new System.Drawing.Point(0, 118);
            this.btnMeusEventos.Margin = new System.Windows.Forms.Padding(4);
            this.btnMeusEventos.Name = "btnMeusEventos";
            this.btnMeusEventos.Size = new System.Drawing.Size(200, 49);
            this.btnMeusEventos.TabIndex = 3;
            this.btnMeusEventos.Text = "Meus Eventos";
            this.btnMeusEventos.UseVisualStyleBackColor = true;
            this.btnMeusEventos.Click += new System.EventHandler(this.btnMeusEventos_Click);
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(0, 314);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(200, 49);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnTrocarPerfil
            // 
            this.btnTrocarPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrocarPerfil.FlatAppearance.BorderSize = 0;
            this.btnTrocarPerfil.Location = new System.Drawing.Point(0, 167);
            this.btnTrocarPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrocarPerfil.Name = "btnTrocarPerfil";
            this.btnTrocarPerfil.Size = new System.Drawing.Size(200, 49);
            this.btnTrocarPerfil.TabIndex = 2;
            this.btnTrocarPerfil.Text = "Trocar Perfil";
            this.btnTrocarPerfil.UseVisualStyleBackColor = true;
            this.btnTrocarPerfil.Click += new System.EventHandler(this.btnTrocarPerfil_Click);
            // 
            // btnConf
            // 
            this.btnConf.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnConf.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConf.FlatAppearance.BorderSize = 0;
            this.btnConf.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConf.Location = new System.Drawing.Point(0, 69);
            this.btnConf.Margin = new System.Windows.Forms.Padding(4);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(200, 49);
            this.btnConf.TabIndex = 2;
            this.btnConf.Text = "Configurações";
            this.btnConf.UseVisualStyleBackColor = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(70, 9);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(72, 16);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "Username";
            // 
            // btnLogOff
            // 
            this.btnLogOff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogOff.FlatAppearance.BorderSize = 0;
            this.btnLogOff.Location = new System.Drawing.Point(0, 265);
            this.btnLogOff.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(200, 49);
            this.btnLogOff.TabIndex = 8;
            this.btnLogOff.Text = "Log Off";
            this.btnLogOff.UseVisualStyleBackColor = true;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnLogOff);
            this.panel1.Controls.Add(this.btnListar);
            this.panel1.Controls.Add(this.btnTrocarPerfil);
            this.panel1.Controls.Add(this.btnMeusEventos);
            this.panel1.Controls.Add(this.btnConf);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 561);
            this.panel1.TabIndex = 9;
            // 
            // btnListar
            // 
            this.btnListar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListar.Location = new System.Drawing.Point(0, 216);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(200, 49);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "Listar Eventos/Musicos";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblPerfilType);
            this.panel2.Controls.Add(this.btnProfileImage);
            this.panel2.Controls.Add(this.lblUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 69);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(70, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Perfil:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(200, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(784, 561);
            this.pnlPrincipal.TabIndex = 10;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProfileImage;
        private System.Windows.Forms.Label lblPerfilType;
        private System.Windows.Forms.Button btnMeusEventos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnTrocarPerfil;
        private System.Windows.Forms.Button btnConf;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListar;
    }
}