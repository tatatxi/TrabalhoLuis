using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleTrocaOleo
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtUsuario.Text) || (string.IsNullOrEmpty(txtSenha.Text))))
            // se tiver sem dados alguma das txt's
            {
                txtUsuario.Text = "";
                MessageBox.Show("Insira seus Dados de Login!");
            }

            else
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Properties.Settings.Default.Con01;
                    con.Open();

                    string query = "SELECT * FROM usuarios WHERE USUARIO=@USUARIO AND SENHA=@SENHA";

                    SqlCommand cmdo = new SqlCommand(query, con);

                    cmdo.Parameters.AddWithValue("@USUARIO", txtUsuario.Text);
                    cmdo.Parameters.AddWithValue("@SENHA", txtSenha.Text);

                    SqlDataReader dr = cmdo.ExecuteReader();

                    if (dr.Read())
                    {
                        frmControleTroca tela = new frmControleTroca();
                        tela.Show();
                        this.Hide();

                    }
                    else
                    {
                        txtUsuario.Text = "";
                        txtSenha.Text = "";
                        MessageBox.Show("Erro: Usuario e/ou Senha não correspondem!");
                    }

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao Iniciar!\n" + erro);
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
