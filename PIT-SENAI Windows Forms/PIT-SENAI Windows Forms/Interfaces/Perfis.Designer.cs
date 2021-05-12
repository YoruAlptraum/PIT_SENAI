
namespace PIT_SENAI_Windows_Forms
{
    partial class Perfis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfis));
            this.btnMusico = new System.Windows.Forms.Button();
            this.btnOrganizador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMusico
            // 
            resources.ApplyResources(this.btnMusico, "btnMusico");
            this.btnMusico.Name = "btnMusico";
            this.btnMusico.UseVisualStyleBackColor = true;
            this.btnMusico.Click += new System.EventHandler(this.btnMusico_Click);
            // 
            // btnOrganizador
            // 
            resources.ApplyResources(this.btnOrganizador, "btnOrganizador");
            this.btnOrganizador.Name = "btnOrganizador";
            this.btnOrganizador.UseVisualStyleBackColor = true;
            this.btnOrganizador.Click += new System.EventHandler(this.btnOrganizador_Click);
            // 
            // Perfis
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOrganizador);
            this.Controls.Add(this.btnMusico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Perfis";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusico;
        private System.Windows.Forms.Button btnOrganizador;
    }
}