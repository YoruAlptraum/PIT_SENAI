
namespace PIT_SENAI_Windows_Forms.Interfaces
{
    partial class CadastroMusico
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroMusico));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDescriçao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.llbVoltar = new System.Windows.Forms.LinkLabel();
            this.cmbInstrumento = new System.Windows.Forms.ComboBox();
            this.cmbEstiloMusical = new System.Windows.Forms.ComboBox();
            this.btnAddInst = new System.Windows.Forms.Button();
            this.btnAddEstilo = new System.Windows.Forms.Button();
            this.lvwInstrumentos = new System.Windows.Forms.ListView();
            this.btnRemoveInst = new System.Windows.Forms.Button();
            this.btnRemoverEstilo = new System.Windows.Forms.Button();
            this.lvwEstilosMusicais = new System.Windows.Forms.ListView();
            this.txbRegiao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkPublico = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txbContato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instrumento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estilo musical:";
            // 
            // txbDescriçao
            // 
            this.txbDescriçao.Location = new System.Drawing.Point(56, 376);
            this.txbDescriçao.Name = "txbDescriçao";
            this.txbDescriçao.Size = new System.Drawing.Size(512, 23);
            this.txbDescriçao.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descrição:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(493, 450);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 30);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // llbVoltar
            // 
            this.llbVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.llbVoltar.AutoSize = true;
            this.llbVoltar.Location = new System.Drawing.Point(471, 489);
            this.llbVoltar.Name = "llbVoltar";
            this.llbVoltar.Size = new System.Drawing.Size(131, 16);
            this.llbVoltar.TabIndex = 9;
            this.llbVoltar.TabStop = true;
            this.llbVoltar.Text = "Voltar a tela Perfis";
            this.llbVoltar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbVoltar_Clicked);
            // 
            // cmbInstrumento
            // 
            this.cmbInstrumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstrumento.FormattingEnabled = true;
            this.cmbInstrumento.Location = new System.Drawing.Point(56, 47);
            this.cmbInstrumento.Name = "cmbInstrumento";
            this.cmbInstrumento.Size = new System.Drawing.Size(328, 24);
            this.cmbInstrumento.TabIndex = 10;
            this.cmbInstrumento.Click += new System.EventHandler(this.cmbInstrumento_Click);
            // 
            // cmbEstiloMusical
            // 
            this.cmbEstiloMusical.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstiloMusical.FormattingEnabled = true;
            this.cmbEstiloMusical.Location = new System.Drawing.Point(56, 189);
            this.cmbEstiloMusical.Name = "cmbEstiloMusical";
            this.cmbEstiloMusical.Size = new System.Drawing.Size(328, 24);
            this.cmbEstiloMusical.TabIndex = 12;
            this.cmbEstiloMusical.Click += new System.EventHandler(this.cmbEstiloMusical_Click);
            // 
            // btnAddInst
            // 
            this.btnAddInst.Location = new System.Drawing.Point(390, 47);
            this.btnAddInst.Name = "btnAddInst";
            this.btnAddInst.Size = new System.Drawing.Size(86, 24);
            this.btnAddInst.TabIndex = 13;
            this.btnAddInst.Text = "Adicionar";
            this.btnAddInst.UseVisualStyleBackColor = true;
            this.btnAddInst.Click += new System.EventHandler(this.btnAddInst_Click);
            // 
            // btnAddEstilo
            // 
            this.btnAddEstilo.Location = new System.Drawing.Point(390, 189);
            this.btnAddEstilo.Name = "btnAddEstilo";
            this.btnAddEstilo.Size = new System.Drawing.Size(86, 24);
            this.btnAddEstilo.TabIndex = 15;
            this.btnAddEstilo.Text = "Adicionar";
            this.btnAddEstilo.UseVisualStyleBackColor = true;
            this.btnAddEstilo.Click += new System.EventHandler(this.btnAddEstilo_Click);
            // 
            // lvwInstrumentos
            // 
            this.lvwInstrumentos.HideSelection = false;
            this.lvwInstrumentos.Location = new System.Drawing.Point(56, 77);
            this.lvwInstrumentos.Name = "lvwInstrumentos";
            this.lvwInstrumentos.Size = new System.Drawing.Size(512, 90);
            this.lvwInstrumentos.TabIndex = 16;
            this.lvwInstrumentos.UseCompatibleStateImageBehavior = false;
            this.lvwInstrumentos.View = System.Windows.Forms.View.List;
            this.lvwInstrumentos.SelectedIndexChanged += new System.EventHandler(this.lvwInstrumentos_SelectedIndexChanged);
            // 
            // btnRemoveInst
            // 
            this.btnRemoveInst.Location = new System.Drawing.Point(482, 46);
            this.btnRemoveInst.Name = "btnRemoveInst";
            this.btnRemoveInst.Size = new System.Drawing.Size(86, 24);
            this.btnRemoveInst.TabIndex = 17;
            this.btnRemoveInst.Text = "Remover";
            this.btnRemoveInst.UseVisualStyleBackColor = true;
            this.btnRemoveInst.Click += new System.EventHandler(this.btnRemoveInst_Click);
            // 
            // btnRemoverEstilo
            // 
            this.btnRemoverEstilo.Location = new System.Drawing.Point(482, 189);
            this.btnRemoverEstilo.Name = "btnRemoverEstilo";
            this.btnRemoverEstilo.Size = new System.Drawing.Size(86, 24);
            this.btnRemoverEstilo.TabIndex = 18;
            this.btnRemoverEstilo.Text = "Remover";
            this.btnRemoverEstilo.UseVisualStyleBackColor = true;
            this.btnRemoverEstilo.Click += new System.EventHandler(this.btnRemoverEstilo_Click);
            // 
            // lvwEstilosMusicais
            // 
            this.lvwEstilosMusicais.HideSelection = false;
            this.lvwEstilosMusicais.Location = new System.Drawing.Point(56, 219);
            this.lvwEstilosMusicais.Name = "lvwEstilosMusicais";
            this.lvwEstilosMusicais.Size = new System.Drawing.Size(512, 90);
            this.lvwEstilosMusicais.TabIndex = 19;
            this.lvwEstilosMusicais.UseCompatibleStateImageBehavior = false;
            this.lvwEstilosMusicais.View = System.Windows.Forms.View.List;
            this.lvwEstilosMusicais.SelectedIndexChanged += new System.EventHandler(this.lvwEstilosMusicais_SelectedIndexChanged);
            // 
            // txbRegiao
            // 
            this.txbRegiao.Location = new System.Drawing.Point(56, 331);
            this.txbRegiao.Name = "txbRegiao";
            this.txbRegiao.Size = new System.Drawing.Size(512, 23);
            this.txbRegiao.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Região:";
            // 
            // chkPublico
            // 
            this.chkPublico.AutoSize = true;
            this.chkPublico.Location = new System.Drawing.Point(56, 450);
            this.chkPublico.Name = "chkPublico";
            this.chkPublico.Size = new System.Drawing.Size(112, 20);
            this.chkPublico.TabIndex = 22;
            this.chkPublico.Text = "Perfil privado";
            this.toolTip1.SetToolTip(this.chkPublico, "Ao marcar essa opção o seu perfil não irá aparecer para na busca de músicos,\r\nou " +
        "seja te impedirá de receber propóstas para tocar em eventos.");
            this.chkPublico.UseVisualStyleBackColor = true;
            // 
            // txbContato
            // 
            this.txbContato.Location = new System.Drawing.Point(56, 421);
            this.txbContato.Name = "txbContato";
            this.txbContato.Size = new System.Drawing.Size(512, 23);
            this.txbContato.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Contato:";
            // 
            // CadastroMusico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 514);
            this.Controls.Add(this.txbContato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkPublico);
            this.Controls.Add(this.txbRegiao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lvwEstilosMusicais);
            this.Controls.Add(this.btnRemoverEstilo);
            this.Controls.Add(this.btnRemoveInst);
            this.Controls.Add(this.lvwInstrumentos);
            this.Controls.Add(this.btnAddEstilo);
            this.Controls.Add(this.btnAddInst);
            this.Controls.Add(this.cmbEstiloMusical);
            this.Controls.Add(this.cmbInstrumento);
            this.Controls.Add(this.llbVoltar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txbDescriçao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastroMusico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Musico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbDescriçao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.LinkLabel llbVoltar;
        private System.Windows.Forms.ComboBox cmbInstrumento;
        private System.Windows.Forms.ComboBox cmbEstiloMusical;
        private System.Windows.Forms.Button btnAddInst;
        private System.Windows.Forms.Button btnAddEstilo;
        private System.Windows.Forms.ListView lvwInstrumentos;
        private System.Windows.Forms.Button btnRemoveInst;
        private System.Windows.Forms.Button btnRemoverEstilo;
        private System.Windows.Forms.ListView lvwEstilosMusicais;
        private System.Windows.Forms.TextBox txbRegiao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkPublico;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txbContato;
        private System.Windows.Forms.Label label2;
    }
}