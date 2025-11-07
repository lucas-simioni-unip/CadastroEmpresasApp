using System;
using System.Windows.Forms;

namespace CadastroEmpresasApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtSenha.Text == "123")
            {
                FrmEmpresa frm = new FrmEmpresa();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}