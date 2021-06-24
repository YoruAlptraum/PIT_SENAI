
namespace PIT_SENAI_Windows_Forms.Interfaces
{
    partial class CadastroOrganizador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroOrganizador));
            this.txbDescriçao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.llbVoltar = new System.Windows.Forms.LinkLabel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbRegiao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbDescriçao
            // 
            this.txbDescriçao.Location = new System.Drawing.Point(48, 131);
            this.txbDescriçao.Name = "txbDescriçao";
            this.txbDescriçao.Size = new System.Drawing.Size(358, 23);
            this.txbDescriçao.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descrição:";
            // 
            // llbVoltar
            // 
            this.llbVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.llbVoltar.AutoSize = true;
            this.llbVoltar.Location = new System.Drawing.Point(308, 227);
            this.llbVoltar.Name = "llbVoltar";
            this.llbVoltar.Size = new System.Drawing.Size(131, 16);
            this.llbVoltar.TabIndex = 11;
            this.llbVoltar.TabStop = true;
            this.llbVoltar.Text = "Voltar a tela Perfis";
            this.llbVoltar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbVoltar_Clicked);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(331, 160);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 10;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Região:";
            // 
            // txbRegiao
            // 
            this.txbRegiao.Location = new System.Drawing.Point(48, 82);
            this.txbRegiao.Name = "txbRegiao";
            this.txbRegiao.Size = new System.Drawing.Size(358, 23);
            this.txbRegiao.TabIndex = 13;
            // 
            // CadastroOrganizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 252);
            this.Controls.Add(this.txbRegiao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.llbVoltar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txbDescriçao);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastroOrganizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Organizador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbDescriçao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel llbVoltar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbRegiao;
    }
}