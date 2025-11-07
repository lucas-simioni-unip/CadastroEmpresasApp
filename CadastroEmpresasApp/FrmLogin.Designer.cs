using System.Drawing;
using System.Windows.Forms;

namespace CadastroEmpresasApp
{
    partial class FrmLogin
    {
        private Label lblUsuario;
        private Label lblSenha;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnEntrar;

        private void InitializeComponent()
        {
            lblUsuario = new Label();
            lblSenha = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.Location = new Point(30, 30);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(60, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuário:";
            // 
            // lblSenha
            // 
            lblSenha.Location = new Point(30, 70);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(60, 20);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(100, 30);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(200, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(100, 70);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(200, 23);
            txtSenha.TabIndex = 3;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(100, 110);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(100, 30);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.Click += btnEntrar_Click;
            // 
            // FrmLogin
            // 
            ClientSize = new Size(350, 180);
            Controls.Add(lblUsuario);
            Controls.Add(txtUsuario);
            Controls.Add(lblSenha);
            Controls.Add(txtSenha);
            Controls.Add(btnEntrar);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FrmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}