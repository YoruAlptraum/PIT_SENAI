
namespace PIT_SENAI_Windows_Forms.Interfaces
{
    partial class SubListaMusicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubListaMusicos));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvwMusicos = new System.Windows.Forms.ListView();
            this.chNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescriçao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRegiao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chContato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 52);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(313, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Músicos";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 472);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 89);
            this.panel1.TabIndex = 4;
            // 
            // lvwMusicos
            // 
            this.lvwMusicos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNome,
            this.chDescriçao,
            this.chRegiao,
            this.chContato});
            this.lvwMusicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwMusicos.FullRowSelect = true;
            this.lvwMusicos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwMusicos.HideSelection = false;
            this.lvwMusicos.Location = new System.Drawing.Point(0, 52);
            this.lvwMusicos.Name = "lvwMusicos";
            this.lvwMusicos.Size = new System.Drawing.Size(784, 420);
            this.lvwMusicos.TabIndex = 5;
            this.lvwMusicos.UseCompatibleStateImageBehavior = false;
            this.lvwMusicos.View = System.Windows.Forms.View.Details;
            // 
            // chNome
            // 
            this.chNome.Text = "Nome";
            this.chNome.Width = 149;
            // 
            // chDescriçao
            // 
            this.chDescriçao.Text = "Descrição";
            this.chDescriçao.Width = 335;
            // 
            // chRegiao
            // 
            this.chRegiao.Text = "Região";
            this.chRegiao.Width = 142;
            // 
            // chContato
            // 
            this.chContato.Text = "Contato";
            this.chContato.Width = 153;
            // 
            // SubListaMusicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lvwMusicos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SubListaMusicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SubListaMusicos";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvwMusicos;
        private System.Windows.Forms.ColumnHeader chNome;
        private System.Windows.Forms.ColumnHeader chDescriçao;
        private System.Windows.Forms.ColumnHeader chRegiao;
        private System.Windows.Forms.ColumnHeader chContato;
    }
}