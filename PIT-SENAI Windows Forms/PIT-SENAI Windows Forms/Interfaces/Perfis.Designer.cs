
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
            this.btn_perfilMusico = new System.Windows.Forms.Button();
            this.btn_perfilOrganizador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_perfilMusico
            // 
            resources.ApplyResources(this.btn_perfilMusico, "btn_perfilMusico");
            this.btn_perfilMusico.Name = "btn_perfilMusico";
            this.btn_perfilMusico.UseVisualStyleBackColor = true;
            this.btn_perfilMusico.Click += new System.EventHandler(this.btn_perfilMusico_Click);
            // 
            // btn_perfilOrganizador
            // 
            resources.ApplyResources(this.btn_perfilOrganizador, "btn_perfilOrganizador");
            this.btn_perfilOrganizador.Name = "btn_perfilOrganizador";
            this.btn_perfilOrganizador.UseVisualStyleBackColor = true;
            // 
            // Perfis
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_perfilOrganizador);
            this.Controls.Add(this.btn_perfilMusico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Perfis";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_perfilMusico;
        private System.Windows.Forms.Button btn_perfilOrganizador;
    }
}