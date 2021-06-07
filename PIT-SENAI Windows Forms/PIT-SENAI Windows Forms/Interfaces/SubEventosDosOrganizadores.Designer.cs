
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
            this.lvwEventos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvwEventos
            // 
            this.lvwEventos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwEventos.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.lvwEventos.HideSelection = false;
            this.lvwEventos.Location = new System.Drawing.Point(0, 0);
            this.lvwEventos.Margin = new System.Windows.Forms.Padding(4);
            this.lvwEventos.Name = "lvwEventos";
            this.lvwEventos.Size = new System.Drawing.Size(784, 561);
            this.lvwEventos.TabIndex = 0;
            this.lvwEventos.UseCompatibleStateImageBehavior = false;
            this.lvwEventos.View = System.Windows.Forms.View.Details;
            // 
            // SubEventosDosOrganizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lvwEventos);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SubEventosDosOrganizadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eventos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwEventos;
    }
}