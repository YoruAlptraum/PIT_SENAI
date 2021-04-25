
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
            this.btn_profileImage = new System.Windows.Forms.Button();
            this.btn_Conf = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lbl_perfilType = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btn_profileImage
            // 
            this.btn_profileImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_profileImage.Location = new System.Drawing.Point(882, 13);
            this.btn_profileImage.Name = "btn_profileImage";
            this.btn_profileImage.Size = new System.Drawing.Size(50, 50);
            this.btn_profileImage.TabIndex = 0;
            this.btn_profileImage.UseVisualStyleBackColor = true;
            // 
            // btn_Conf
            // 
            this.btn_Conf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Conf.Location = new System.Drawing.Point(842, 69);
            this.btn_Conf.Name = "btn_Conf";
            this.btn_Conf.Size = new System.Drawing.Size(90, 35);
            this.btn_Conf.TabIndex = 1;
            this.btn_Conf.Text = "Configurações";
            this.btn_Conf.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(842, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Trocar\r\nPerfil";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(842, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "Eventos";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(842, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "Sair";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbl_perfilType
            // 
            this.lbl_perfilType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_perfilType.AutoSize = true;
            this.lbl_perfilType.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_perfilType.Location = new System.Drawing.Point(372, 20);
            this.lbl_perfilType.Name = "lbl_perfilType";
            this.lbl_perfilType.Size = new System.Drawing.Size(105, 36);
            this.lbl_perfilType.TabIndex = 5;
            this.lbl_perfilType.Text = "Perfil\r\nOrganizador";
            this.lbl_perfilType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(34, 69);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(785, 396);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbl_perfilType);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Conf);
            this.Controls.Add(this.btn_profileImage);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_profileImage;
        private System.Windows.Forms.Button btn_Conf;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbl_perfilType;
        private System.Windows.Forms.ListView listView1;
    }
}