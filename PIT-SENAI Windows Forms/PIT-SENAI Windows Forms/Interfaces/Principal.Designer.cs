﻿
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
            this.lbl_perfilType = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnEventos = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnTrocarPerfil = new System.Windows.Forms.Button();
            this.btnConf = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProfileImage
            // 
            this.btnProfileImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProfileImage.Location = new System.Drawing.Point(1176, 15);
            this.btnProfileImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProfileImage.Name = "btnProfileImage";
            this.btnProfileImage.Size = new System.Drawing.Size(67, 62);
            this.btnProfileImage.TabIndex = 0;
            this.btnProfileImage.UseVisualStyleBackColor = true;
            // 
            // lbl_perfilType
            // 
            this.lbl_perfilType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_perfilType.AutoSize = true;
            this.lbl_perfilType.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_perfilType.Location = new System.Drawing.Point(496, 25);
            this.lbl_perfilType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_perfilType.Name = "lbl_perfilType";
            this.lbl_perfilType.Size = new System.Drawing.Size(105, 36);
            this.lbl_perfilType.TabIndex = 5;
            this.lbl_perfilType.Text = "Perfil\r\nOrganizador";
            this.lbl_perfilType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(45, 85);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1045, 486);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnEventos
            // 
            this.btnEventos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEventos.Location = new System.Drawing.Point(1109, 198);
            this.btnEventos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(133, 49);
            this.btnEventos.TabIndex = 3;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Location = new System.Drawing.Point(1109, 311);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(133, 49);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnTrocarPerfil
            // 
            this.btnTrocarPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrocarPerfil.Location = new System.Drawing.Point(1109, 142);
            this.btnTrocarPerfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTrocarPerfil.Name = "btnTrocarPerfil";
            this.btnTrocarPerfil.Size = new System.Drawing.Size(133, 49);
            this.btnTrocarPerfil.TabIndex = 2;
            this.btnTrocarPerfil.Text = "Trocar\r\nPerfil";
            this.btnTrocarPerfil.UseVisualStyleBackColor = true;
            this.btnTrocarPerfil.Click += new System.EventHandler(this.btnTrocarPerfil_Click);
            // 
            // btnConf
            // 
            this.btnConf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConf.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnConf.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConf.Location = new System.Drawing.Point(1109, 85);
            this.btnConf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(133, 49);
            this.btnConf.TabIndex = 1;
            this.btnConf.Text = "Configurações";
            this.btnConf.UseVisualStyleBackColor = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(1095, 15);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(72, 16);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "Username";
            // 
            // btnLogOff
            // 
            this.btnLogOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOff.Location = new System.Drawing.Point(1109, 255);
            this.btnLogOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(133, 49);
            this.btnLogOff.TabIndex = 8;
            this.btnLogOff.Text = "Log Off";
            this.btnLogOff.UseVisualStyleBackColor = true;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 617);
            this.Controls.Add(this.btnLogOff);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnTrocarPerfil);
            this.Controls.Add(this.btnEventos);
            this.Controls.Add(this.btnConf);
            this.Controls.Add(this.btnProfileImage);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbl_perfilType);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProfileImage;
        private System.Windows.Forms.Label lbl_perfilType;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnTrocarPerfil;
        private System.Windows.Forms.Button btnConf;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnLogOff;
    }
}