
namespace PIT_SENAI_Windows_Forms.Interfaces
{
    partial class SubConfig
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbConfSenha = new System.Windows.Forms.TextBox();
            this.lblCS = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbContato = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbMRegiao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbORegiao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chkPublico = new System.Windows.Forms.CheckBox();
            this.grpConfigGeral = new System.Windows.Forms.GroupBox();
            this.grpConfigOrganizador = new System.Windows.Forms.GroupBox();
            this.txbODescriçao = new System.Windows.Forms.TextBox();
            this.grpConfigMusico = new System.Windows.Forms.GroupBox();
            this.cmbSelect = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lvwInstEstil = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbInstEstil = new System.Windows.Forms.ComboBox();
            this.txbMDescriçao = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblConfirmeSenha = new System.Windows.Forms.Label();
            this.grpConfigGeral.SuspendLayout();
            this.grpConfigOrganizador.SuspendLayout();
            this.grpConfigMusico.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txbNome
            // 
            this.txbNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbNome.Location = new System.Drawing.Point(9, 38);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(340, 23);
            this.txbNome.TabIndex = 1;
            // 
            // txbUsuario
            // 
            this.txbUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbUsuario.Location = new System.Drawing.Point(9, 83);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(340, 23);
            this.txbUsuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuário:";
            // 
            // txbSenha
            // 
            this.txbSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbSenha.Location = new System.Drawing.Point(396, 38);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(340, 23);
            this.txbSenha.TabIndex = 5;
            this.txbSenha.TextChanged += new System.EventHandler(this.txbSenha_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha:";
            // 
            // txbConfSenha
            // 
            this.txbConfSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbConfSenha.BackColor = System.Drawing.Color.White;
            this.txbConfSenha.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txbConfSenha.Location = new System.Drawing.Point(396, 83);
            this.txbConfSenha.Name = "txbConfSenha";
            this.txbConfSenha.PasswordChar = '*';
            this.txbConfSenha.Size = new System.Drawing.Size(340, 23);
            this.txbConfSenha.TabIndex = 7;
            this.txbConfSenha.TextChanged += new System.EventHandler(this.txbSenha_TextChanged);
            // 
            // lblCS
            // 
            this.lblCS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCS.AutoSize = true;
            this.lblCS.Location = new System.Drawing.Point(393, 64);
            this.lblCS.Name = "lblCS";
            this.lblCS.Size = new System.Drawing.Size(128, 16);
            this.lblCS.TabIndex = 6;
            this.lblCS.Text = "Confirme a senha:";
            // 
            // txbEmail
            // 
            this.txbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbEmail.Location = new System.Drawing.Point(9, 128);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(340, 23);
            this.txbEmail.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "E-mail:";
            // 
            // txbContato
            // 
            this.txbContato.Location = new System.Drawing.Point(9, 128);
            this.txbContato.Name = "txbContato";
            this.txbContato.Size = new System.Drawing.Size(340, 23);
            this.txbContato.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Contato:";
            // 
            // txbMRegiao
            // 
            this.txbMRegiao.Location = new System.Drawing.Point(9, 83);
            this.txbMRegiao.Name = "txbMRegiao";
            this.txbMRegiao.Size = new System.Drawing.Size(340, 23);
            this.txbMRegiao.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Região:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Descrição:";
            // 
            // txbORegiao
            // 
            this.txbORegiao.Location = new System.Drawing.Point(396, 38);
            this.txbORegiao.Name = "txbORegiao";
            this.txbORegiao.Size = new System.Drawing.Size(340, 23);
            this.txbORegiao.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(393, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Região:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Descrição:";
            // 
            // chkPublico
            // 
            this.chkPublico.AutoSize = true;
            this.chkPublico.Location = new System.Drawing.Point(9, 157);
            this.chkPublico.Name = "chkPublico";
            this.chkPublico.Size = new System.Drawing.Size(110, 20);
            this.chkPublico.TabIndex = 20;
            this.chkPublico.Text = "Perfil Público";
            this.toolTip1.SetToolTip(this.chkPublico, "Ao marcar essa opção o seu perfil não irá aparecer para na busca de músicos,");
            this.chkPublico.UseVisualStyleBackColor = true;
            // 
            // grpConfigGeral
            // 
            this.grpConfigGeral.Controls.Add(this.lblConfirmeSenha);
            this.grpConfigGeral.Controls.Add(this.label1);
            this.grpConfigGeral.Controls.Add(this.txbNome);
            this.grpConfigGeral.Controls.Add(this.label2);
            this.grpConfigGeral.Controls.Add(this.txbEmail);
            this.grpConfigGeral.Controls.Add(this.txbUsuario);
            this.grpConfigGeral.Controls.Add(this.label5);
            this.grpConfigGeral.Controls.Add(this.label3);
            this.grpConfigGeral.Controls.Add(this.txbConfSenha);
            this.grpConfigGeral.Controls.Add(this.txbSenha);
            this.grpConfigGeral.Controls.Add(this.lblCS);
            this.grpConfigGeral.Location = new System.Drawing.Point(12, 46);
            this.grpConfigGeral.Name = "grpConfigGeral";
            this.grpConfigGeral.Size = new System.Drawing.Size(760, 162);
            this.grpConfigGeral.TabIndex = 21;
            this.grpConfigGeral.TabStop = false;
            this.grpConfigGeral.Text = "Configurações Gerais:";
            // 
            // grpConfigOrganizador
            // 
            this.grpConfigOrganizador.Controls.Add(this.txbODescriçao);
            this.grpConfigOrganizador.Controls.Add(this.label10);
            this.grpConfigOrganizador.Controls.Add(this.label9);
            this.grpConfigOrganizador.Controls.Add(this.txbORegiao);
            this.grpConfigOrganizador.Location = new System.Drawing.Point(12, 6);
            this.grpConfigOrganizador.Name = "grpConfigOrganizador";
            this.grpConfigOrganizador.Size = new System.Drawing.Size(760, 77);
            this.grpConfigOrganizador.TabIndex = 22;
            this.grpConfigOrganizador.TabStop = false;
            this.grpConfigOrganizador.Text = "Perfil Organizador:";
            // 
            // txbODescriçao
            // 
            this.txbODescriçao.Location = new System.Drawing.Point(9, 38);
            this.txbODescriçao.Name = "txbODescriçao";
            this.txbODescriçao.Size = new System.Drawing.Size(340, 23);
            this.txbODescriçao.TabIndex = 20;
            // 
            // grpConfigMusico
            // 
            this.grpConfigMusico.Controls.Add(this.cmbSelect);
            this.grpConfigMusico.Controls.Add(this.btnRemove);
            this.grpConfigMusico.Controls.Add(this.lvwInstEstil);
            this.grpConfigMusico.Controls.Add(this.btnAdd);
            this.grpConfigMusico.Controls.Add(this.cmbInstEstil);
            this.grpConfigMusico.Controls.Add(this.txbMDescriçao);
            this.grpConfigMusico.Controls.Add(this.label8);
            this.grpConfigMusico.Controls.Add(this.label7);
            this.grpConfigMusico.Controls.Add(this.chkPublico);
            this.grpConfigMusico.Controls.Add(this.txbMRegiao);
            this.grpConfigMusico.Controls.Add(this.txbContato);
            this.grpConfigMusico.Controls.Add(this.label6);
            this.grpConfigMusico.Location = new System.Drawing.Point(12, 9);
            this.grpConfigMusico.Name = "grpConfigMusico";
            this.grpConfigMusico.Size = new System.Drawing.Size(760, 182);
            this.grpConfigMusico.TabIndex = 23;
            this.grpConfigMusico.TabStop = false;
            this.grpConfigMusico.Text = "Perfil Músico:";
            // 
            // cmbSelect
            // 
            this.cmbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelect.FormattingEnabled = true;
            this.cmbSelect.Items.AddRange(new object[] {
            "Instrumentos",
            "Estilos Musicais"});
            this.cmbSelect.Location = new System.Drawing.Point(396, 23);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(341, 24);
            this.cmbSelect.TabIndex = 27;
            this.cmbSelect.SelectedIndexChanged += new System.EventHandler(this.cmbSelect_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(651, 53);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(86, 24);
            this.btnRemove.TabIndex = 26;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lvwInstEstil
            // 
            this.lvwInstEstil.HideSelection = false;
            this.lvwInstEstil.Location = new System.Drawing.Point(396, 83);
            this.lvwInstEstil.Name = "lvwInstEstil";
            this.lvwInstEstil.Size = new System.Drawing.Size(340, 68);
            this.lvwInstEstil.TabIndex = 25;
            this.lvwInstEstil.UseCompatibleStateImageBehavior = false;
            this.lvwInstEstil.View = System.Windows.Forms.View.List;
            this.lvwInstEstil.SelectedIndexChanged += new System.EventHandler(this.lvwInstEstil_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(559, 53);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 24);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbInstEstil
            // 
            this.cmbInstEstil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstEstil.FormattingEnabled = true;
            this.cmbInstEstil.Location = new System.Drawing.Point(396, 53);
            this.cmbInstEstil.Name = "cmbInstEstil";
            this.cmbInstEstil.Size = new System.Drawing.Size(157, 24);
            this.cmbInstEstil.TabIndex = 23;
            // 
            // txbMDescriçao
            // 
            this.txbMDescriçao.Location = new System.Drawing.Point(9, 38);
            this.txbMDescriçao.Name = "txbMDescriçao";
            this.txbMDescriçao.Size = new System.Drawing.Size(340, 23);
            this.txbMDescriçao.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.grpConfigGeral);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 215);
            this.panel1.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(283, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(219, 34);
            this.label11.TabIndex = 0;
            this.label11.Text = "Configurações";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 511);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 50);
            this.panel2.TabIndex = 25;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalvar.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F);
            this.btnSalvar.Location = new System.Drawing.Point(0, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(784, 50);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar Alterações";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 215);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpConfigOrganizador);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpConfigMusico);
            this.splitContainer1.Size = new System.Drawing.Size(784, 296);
            this.splitContainer1.SplitterDistance = 90;
            this.splitContainer1.TabIndex = 26;
            // 
            // lblConfirmeSenha
            // 
            this.lblConfirmeSenha.AutoSize = true;
            this.lblConfirmeSenha.Location = new System.Drawing.Point(393, 109);
            this.lblConfirmeSenha.Name = "lblConfirmeSenha";
            this.lblConfirmeSenha.Size = new System.Drawing.Size(342, 16);
            this.lblConfirmeSenha.TabIndex = 10;
            this.lblConfirmeSenha.Text = "Senha e confirmação de senha precisam ser iguais";
            // 
            // SubConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SubConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configurações";
            this.grpConfigGeral.ResumeLayout(false);
            this.grpConfigGeral.PerformLayout();
            this.grpConfigOrganizador.ResumeLayout(false);
            this.grpConfigOrganizador.PerformLayout();
            this.grpConfigMusico.ResumeLayout(false);
            this.grpConfigMusico.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbConfSenha;
        private System.Windows.Forms.Label lblCS;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbContato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbMRegiao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbORegiao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkPublico;
        private System.Windows.Forms.GroupBox grpConfigGeral;
        private System.Windows.Forms.GroupBox grpConfigOrganizador;
        private System.Windows.Forms.GroupBox grpConfigMusico;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txbODescriçao;
        private System.Windows.Forms.TextBox txbMDescriçao;
        private System.Windows.Forms.ComboBox cmbSelect;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListView lvwInstEstil;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbInstEstil;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblConfirmeSenha;
    }
}