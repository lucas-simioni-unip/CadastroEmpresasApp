using System;
using System.Windows.Forms;

namespace CadastroEmpresasApp
{
    public partial class FrmEmpresa : Form
    {
        public FrmEmpresa()
        {
            InitializeComponent();

            // Conectando os eventos manualmente
            btnSalvar.Click += new EventHandler(btnSalvar_Click);
            btnLimpar.Click += new EventHandler(btnLimpar_Click);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FrmConfirmacao confirmacao = new FrmConfirmacao();
            confirmacao.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRazaoSocial.Text = "";
            txtNomeFantasia.Text = "";
            txtCNPJ.Text = "";
            txtSegmento.Text = "";
            txtEnderecoId.Text = "";
            dtCadastro.Value = DateTime.Today;
            txtRazaoSocial.Focus();
        }
    }
}