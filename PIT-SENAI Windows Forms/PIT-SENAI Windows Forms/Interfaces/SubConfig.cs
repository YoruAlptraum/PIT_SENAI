using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIT_SENAI_Windows_Forms.Modelo;

namespace PIT_SENAI_Windows_Forms.Interfaces
{
    public partial class SubConfig : Form
    {
        bool inst,tempmusico,temporganizador;
        List<string> instrumentos = new List<string>(), estilos = new List<string>();
        DataTable dt;
        Controle controle = new Controle();
        public SubConfig()
        {
            InitializeComponent();
            cmbSelect.SelectedIndex = 0;
            btnRemove.Enabled = false;
            PreencherConfigGerais();
            if (tempmusico) PreencherPMusico();
            if (temporganizador)  PreencherPOrganizador();
            UpdatelvwInstrumentos();
        }
        #region Preencher Formulário
        //passar os dados recebidos do banco para o formulário
        void PreencherConfigGerais()
        {
            dt =new DataTable();
            //receber dados ConfigGerais
            dt = controle.ConfigGerais();
            //checar e desabilitar os grps de acordo com o bd
            tempmusico = grpConfigMusico.Enabled = BitConverter.ToBoolean((System.Byte[])dt.Rows[0]["temPerfilMusico"], 0);
            temporganizador = grpConfigOrganizador.Enabled = BitConverter.ToBoolean((System.Byte[])dt.Rows[0]["temPerfilOrganizador"], 0);
            //preencher os txbs com os dados gerais
            txbNome.Text = dt.Rows[0]["nome"].ToString();
            txbUsuario.Text = dt.Rows[0]["usuario"].ToString();
            txbEmail.Text = dt.Rows[0]["email"].ToString();
        }
        void PreencherPOrganizador()
        {
            dt = new DataTable();
            dt = controle.ConfigPOrganizador();
            txbODescriçao.Text = dt.Rows[0]["descriçao"].ToString();
            txbORegiao.Text = dt.Rows[0]["regiao"].ToString();
        }
        void PreencherPMusico()
        {
            dt = new DataTable();
            dt = controle.ConfigPMusico();
            txbMDescriçao.Text = dt.Rows[0]["descriçao"].ToString();
            txbMRegiao.Text = dt.Rows[0]["regiao"].ToString();
            txbContato.Text = dt.Rows[0]["contato"].ToString();
            chkPublico.Checked = Convert.ToBoolean(dt.Rows[0]["publico"]);
            instrumentos = controle.ConfigMInst();
            estilos = controle.ConfigMEstilo();
        }
        #endregion
        #region Config lvwInstEstilo
        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = false;
            //Inverter o bool
            if (cmbSelect.SelectedIndex == 0) inst = true;
            else inst = false;
            //atualizar
            UpdatecmbInstEstil();
            //Alterar os itens da lvwInstEstil
            if (inst) UpdatelvwInstrumentos();
            else UpdatelvwEstilosMusicais();
        }

        void UpdatecmbInstEstil()
        {
            if (inst)
            {
                cmbInstEstil.Items.Clear();
                dt = controle.getInstrumentos();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        cmbInstEstil.Items.Add(dr[0]);
                    }
                }
                else MessageBox.Show("No Rows");
            }
            else
            {
                cmbInstEstil.Items.Clear();
                dt = controle.getEstilos();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        cmbInstEstil.Items.Add(dr[0]);
                    }
                }
                else MessageBox.Show("No Rows");
            }
        }

        private void UpdatelvwInstrumentos()
        {
            lvwInstEstil.Items.Clear();
            foreach (var i in instrumentos)
            {
                ListViewItem item = new ListViewItem(i);
                lvwInstEstil.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (inst)
            {
                if (cmbInstEstil.Text.Length > 0)
                {
                    bool tem = false;
                    //adicionar instrumento na lista de instrumentos
                    foreach (var i in instrumentos) if (i.Equals(cmbInstEstil.Text))
                        {
                            tem = true;
                            break;
                        }
                    if (!tem) instrumentos.Add(cmbInstEstil.Text);
                    //e então atualizar a list view
                    UpdatelvwInstrumentos();
                }
            }
            else
            {
                if (cmbInstEstil.Text.Length > 0)
                {
                    bool tem = false;
                    foreach (var i in estilos) if (i.Equals(cmbInstEstil.Text))
                        {
                            tem = true;
                            break;
                        }
                    if (!tem) estilos.Add(cmbInstEstil.Text);
                    UpdatelvwEstilosMusicais();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (inst)
            {
                int index = instrumentos.FindIndex(i => i == lvwInstEstil.SelectedItems[0].Text);
                instrumentos.RemoveAt(index);
                btnRemove.Enabled = false;
                UpdatelvwInstrumentos();
            }
            else
            {
                int index = estilos.FindIndex(es => es == lvwInstEstil.SelectedItems[0].Text);
                estilos.RemoveAt(index);
                btnRemove.Enabled = false;
                UpdatelvwEstilosMusicais();
            }
        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {
            //conferir se o os valores de ambas as txb de senha são iguais
            //se não forem alterar a cor do txb, alterar texto da lblConfirmeSenha
            //e desabilitar o btnSalvar
            if (txbSenha.Text.Equals(txbConfSenha.Text))
            {
                lblCS.ForeColor = txbConfSenha.ForeColor = Color.Black;
                lblConfirmeSenha.Text = "";
                btnSalvar.Enabled = true;
            }
            else
            {
                txbConfSenha.ForeColor = Color.Red;
                lblCS.ForeColor = lblConfirmeSenha.ForeColor = Color.Red;
                lblConfirmeSenha.Text = "Senha e confirmação de senha precisam ser iguais";
                btnSalvar.Enabled = false;
            }
        }

        private void lvwInstEstil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwInstEstil.SelectedItems.Count > 0) btnRemove.Enabled = true;
            else btnRemove.Enabled = false;
        }

        private void UpdatelvwEstilosMusicais()
        {
            lvwInstEstil.Items.Clear();
            foreach (var i in estilos)
            {
                ListViewItem item = new ListViewItem(i);
                lvwInstEstil.Items.Add(item);
            }
        }
        #endregion

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            List<int> instrumentoID = new List<int>();
            List<int> estiloID = new List<int>();
            //pasar instrumentos para id
            dt = new DataTable();
            dt = controle.getInstrumentos();
            if (dt.Rows.Count > 0)
            {
                foreach (var i in instrumentos)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr[0].Equals(i))
                        {
                            //se encontrar o instrumento na lista de instumentos
                            instrumentoID.Add(int.Parse(dr[1].ToString()));
                        }
                    }
                }
            }
            //pasar estilos para id
            dt = new DataTable();
            dt = controle.getEstilos();
            if (dt.Rows.Count > 0)
            {
                foreach (var es in estilos)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr[0].Equals(es))
                        {
                            //se encontrar o instrumento na lista de instumentos
                            estiloID.Add(int.Parse(dr[1].ToString()));
                        }
                    }
                }
            }
            //salvar alterações
            if (tempmusico && temporganizador)
            {
                controle.ConfigSalvar(txbNome.Text, txbUsuario.Text, txbEmail.Text, txbSenha.Text,
                txbODescriçao.Text, txbORegiao.Text,
                txbMDescriçao.Text, txbMRegiao.Text, txbContato.Text, chkPublico.Checked,
                instrumentoID, estiloID);
            }
            else if (temporganizador)
            {
                controle.ConfigSalvar(txbNome.Text, txbUsuario.Text, txbEmail.Text, txbSenha.Text,
                txbODescriçao.Text, txbORegiao.Text);
            }
            else if (tempmusico)
            {
                controle.ConfigSalvar(txbNome.Text, txbUsuario.Text, txbEmail.Text, txbSenha.Text,
                txbMDescriçao.Text, txbMRegiao.Text, txbContato.Text, chkPublico.Checked,
                instrumentoID, estiloID);
            }
            //atualizar o form Principal se possivel
            MessageBox.Show(controle.mensagem);
        }
    }
}
