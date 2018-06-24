using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleTrocaOleo
{
    public partial class frmControleTroca : Form
    {
        public frmControleTroca()
        {
            InitializeComponent();
        }

        private void lblEmailCliente_Click(object sender, EventArgs e)
        {

        }

        private void frmControleTroca_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //.SelectedIndex = -1 foi usado para Limpar os campos do combobox, funciona porque joga um indice negativo
            cmbCliente.SelectedIndex = -1;
            cmbOleo.SelectedIndex = -1;
            cmbFabricante.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;
            cmbCategoria.SelectedIndex = -1;
            txtValorLitro.Clear();
            txtQtdLitro.Clear();
            txtVlrTotal.Clear();
            txtEmailCliente.Clear();
            dtpDataTroca.Focus();
        }
    }
}
