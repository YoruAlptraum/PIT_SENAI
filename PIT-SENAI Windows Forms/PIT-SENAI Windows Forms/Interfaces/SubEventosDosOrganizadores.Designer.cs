
namespace PIT_SENAI_Windows_Forms.Interfaces
{
    partial class SubEventosDosOrganizadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubEventosDosOrganizadores));
            this.lvwEventos = new System.Windows.Forms.ListView();
            this.chEvento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescriçao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLocalizaçao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chContato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCriarEvento = new System.Windows.Forms.Button();
            this.btnDeletarEvento = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbEvento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbLocalizaçao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbContato = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAlterarEvento = new System.Windows.Forms.Button();
            this.txbDescriçao = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwEventos
            // 
            this.lvwEventos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwEventos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chEvento,
            this.chDescriçao,
            this.chLocalizaçao,
            this.chContato});
            this.lvwEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwEventos.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.lvwEventos.FullRowSelect = true;
            this.lvwEventos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwEventos.HideSelection = false;
            this.lvwEventos.Location = new System.Drawing.Point(0, 67);
            this.lvwEventos.Margin = new System.Windows.Forms.Padding(4);
            this.lvwEventos.MultiSelect = false;
            this.lvwEventos.Name = "lvwEventos";
            this.lvwEventos.Size = new System.Drawing.Size(784, 379);
            this.lvwEventos.TabIndex = 0;
            this.lvwEventos.UseCompatibleStateImageBehavior = false;
            this.lvwEventos.View = System.Windows.Forms.View.Details;
            this.lvwEventos.SelectedIndexChanged += new System.EventHandler(this.lvwEventos_SelectedIndexChanged);
            // 
            // chEvento
            // 
            this.chEvento.Text = "Evento";
            this.chEvento.Width = 116;
            // 
            // chDescriçao
            // 
            this.chDescriçao.Text = "Descrição";
            this.chDescriçao.Width = 242;
            // 
            // chLocalizaçao
            // 
            this.chLocalizaçao.Text = "Localização";
            this.chLocalizaçao.Width = 297;
            // 
            // chContato
            // 
            this.chContato.Text = "Contato";
            this.chContato.Width = 126;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 67);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meus Eventos:";
            // 
            // btnCriarEvento
            // 
            this.btnCriarEvento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCriarEvento.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F);
            this.btnCriarEvento.Location = new System.Drawing.Point(12, 68);
            this.btnCriarEvento.Name = "btnCriarEvento";
            this.btnCriarEvento.Size = new System.Drawing.Size(180, 35);
            this.btnCriarEvento.TabIndex = 0;
            this.btnCriarEvento.Text = "Criar Evento";
            this.btnCriarEvento.UseVisualStyleBackColor = true;
            this.btnCriarEvento.Click += new System.EventHandler(this.btnCriarEvento_Click);
            // 
            // btnDeletarEvento
            // 
            this.btnDeletarEvento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletarEvento.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F);
            this.btnDeletarEvento.Location = new System.Drawing.Point(592, 68);
            this.btnDeletarEvento.Name = "btnDeletarEvento";
            this.btnDeletarEvento.Size = new System.Drawing.Size(180, 35);
            this.btnDeletarEvento.TabIndex = 1;
            this.btnDeletarEvento.Text = "Deletar Evento";
            this.btnDeletarEvento.UseVisualStyleBackColor = true;
            this.btnDeletarEvento.Click += new System.EventHandler(this.btnDeletarEvento_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Evento:";
            // 
            // txbEvento
            // 
            this.txbEvento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txbEvento.Location = new System.Drawing.Point(99, 10);
            this.txbEvento.Name = "txbEvento";
            this.txbEvento.Size = new System.Drawing.Size(333, 23);
            this.txbEvento.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição:";
            // 
            // txbLocalizaçao
            // 
            this.txbLocalizaçao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txbLocalizaçao.Location = new System.Drawing.Point(554, 10);
            this.txbLocalizaçao.Name = "txbLocalizaçao";
            this.txbLocalizaçao.Size = new System.Drawing.Size(218, 23);
            this.txbLocalizaçao.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Localização:";
            // 
            // txbContato
            // 
            this.txbContato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txbContato.Location = new System.Drawing.Point(554, 39);
            this.txbContato.Name = "txbContato";
            this.txbContato.Size = new System.Drawing.Size(218, 23);
            this.txbContato.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Contato:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAlterarEvento);
            this.panel1.Controls.Add(this.txbContato);
            this.panel1.Controls.Add(this.btnCriarEvento);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnDeletarEvento);
            this.panel1.Controls.Add(this.txbLocalizaçao);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbEvento);
            this.panel1.Controls.Add(this.txbDescriçao);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 446);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 115);
            this.panel1.TabIndex = 1;
            // 
            // btnAlterarEvento
            // 
            this.btnAlterarEvento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterarEvento.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F);
            this.btnAlterarEvento.Location = new System.Drawing.Point(310, 68);
            this.btnAlterarEvento.Name = "btnAlterarEvento";
            this.btnAlterarEvento.Size = new System.Drawing.Size(180, 35);
            this.btnAlterarEvento.TabIndex = 8;
            this.btnAlterarEvento.Text = "Alterar Evento";
            this.btnAlterarEvento.UseVisualStyleBackColor = true;
            this.btnAlterarEvento.Click += new System.EventHandler(this.btnAlterarEvento_Click);
            // 
            // txbDescriçao
            // 
            this.txbDescriçao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDescriçao.Location = new System.Drawing.Point(99, 39);
            this.txbDescriçao.Name = "txbDescriçao";
            this.txbDescriçao.Size = new System.Drawing.Size(333, 23);
            this.txbDescriçao.TabIndex = 3;
            // 
            // SubEventosDosOrganizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lvwEventos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SubEventosDosOrganizadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eventos";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwEventos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeletarEvento;
        private System.Windows.Forms.Button btnCriarEvento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbEvento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbLocalizaçao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbContato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbDescriçao;
        private System.Windows.Forms.ColumnHeader chEvento;
        private System.Windows.Forms.ColumnHeader chDescriçao;
        private System.Windows.Forms.ColumnHeader chLocalizaçao;
        private System.Windows.Forms.ColumnHeader chContato;
        private System.Windows.Forms.Button btnAlterarEvento;
    }
}