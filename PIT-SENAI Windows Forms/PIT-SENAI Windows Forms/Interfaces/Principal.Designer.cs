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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("aaaa");
            this.btnProfileImage = new System.Windows.Forms.Button();
            this.lblPerfilType = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEventos = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnTrocarPerfil = new System.Windows.Forms.Button();
            this.btnConf = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
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
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(784, 392);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 138;
            // 
            // btnEventos
            // 
            this.btnEventos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEventos.FlatAppearance.BorderSize = 0;
            this.btnEventos.Location = new System.Drawing.Point(0, 118);
            this.btnEventos.Margin = new System.Windows.Forms.Padding(4);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(200, 49);
            this.btnEventos.TabIndex = 3;
            this.btnEventos.Text = "Eventos";
            this.btnEventos.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.Location = new System.Drawing.Point(0, 265);
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
            this.btnLogOff.Location = new System.Drawing.Point(0, 216);
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
            this.panel1.Controls.Add(this.btnTrocarPerfil);
            this.panel1.Controls.Add(this.btnEventos);
            this.panel1.Controls.Add(this.btnConf);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 461);
            this.panel1.TabIndex = 9;
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
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 69);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.listView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 69);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(784, 392);
            this.panel4.TabIndex = 11;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Principal";
            this.Text = "Principal";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProfileImage;
        private System.Windows.Forms.Label lblPerfilType;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnTrocarPerfil;
        private System.Windows.Forms.Button btnConf;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel panel4;
    }
}