using System;
using System.Windows.Forms;

namespace CadastroEmpresasApp
{
    public partial class FrmConfirmacao : Form
    {
        public FrmConfirmacao()
        {
            InitializeComponent();
        }

        private void btnCadastrarMais_Click(object sender, EventArgs e)
        {
            FrmEmpresa frm = new FrmEmpresa();
            frm.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmConfirmacao_Load(object sender, EventArgs e)
        {

        }
    }
}