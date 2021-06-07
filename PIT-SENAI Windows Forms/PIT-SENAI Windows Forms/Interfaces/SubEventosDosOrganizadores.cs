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
    public partial class SubEventosDosOrganizadores : Form
    {
        public SubEventosDosOrganizadores()
        {
            InitializeComponent();
            //buscar no banco de dados os eventos do organizador baseado em seu id
            AtualizarlvwEventos();
        }

        public void AtualizarlvwEventos()
        {
            lvwEventos.Items.Clear();

        }
    }
}
