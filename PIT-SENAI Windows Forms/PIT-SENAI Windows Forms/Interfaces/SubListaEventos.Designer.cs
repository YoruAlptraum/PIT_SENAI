
namespace PIT_SENAI_Windows_Forms.Interfaces
{
    partial class SubListaEventos
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
            this.lvwEventos = new System.Windows.Forms.ListView();
            this.chEvento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescriçao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOrganizador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwEventos
            // 
            this.lvwEventos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chEvento,
            this.chDescriçao,
            this.chOrganizador});
            this.lvwEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwEventos.HideSelection = false;
            this.lvwEventos.Location = new System.Drawing.Point(0, 52);
            this.lvwEventos.Name = "lvwEventos";
            this.lvwEventos.Size = new System.Drawing.Size(784, 509);
            this.lvwEventos.TabIndex = 0;
            this.lvwEventos.UseCompatibleStateImageBehavior = false;
            this.lvwEventos.View = System.Windows.Forms.View.Details;
            // 
            // chEvento
            // 
            this.chEvento.Text = "Evento";
            this.chEvento.Width = 124;
            // 
            // chDescriçao
            // 
            this.chDescriçao.Text = "Descrição";
            this.chDescriçao.Width = 486;
            // 
            // chOrganizador
            // 
            this.chOrganizador.Text = "Organizador";
            this.chOrganizador.Width = 167;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 472);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 89);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 52);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(313, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eventos";
            // 
            // SubListaEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvwEventos);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SubListaEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SubListaEventos";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwEventos;
        private System.Windows.Forms.ColumnHeader chEvento;
        private System.Windows.Forms.ColumnHeader chDescriçao;
        private System.Windows.Forms.ColumnHeader chOrganizador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}