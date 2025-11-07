using System.Drawing;
using System.Windows.Forms;

namespace CadastroEmpresasApp
{
    partial class FrmConfirmacao
    {
        private Label lblMensagem;
        private Button btnCadastrarMais;
        private Button btnSair;

        private void InitializeComponent()
        {
            lblMensagem = new Label();
            btnCadastrarMais = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // lblMensagem
            // 
            lblMensagem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMensagem.ForeColor = Color.Green;
            lblMensagem.Location = new Point(20, 30);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(320, 30);
            lblMensagem.TabIndex = 0;
            lblMensagem.Text = "Empresa cadastrada com sucesso!";
            lblMensagem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCadastrarMais
            // 
            btnCadastrarMais.Location = new Point(40, 80);
            btnCadastrarMais.Name = "btnCadastrarMais";
            btnCadastrarMais.Size = new Size(120, 35);
            btnCadastrarMais.TabIndex = 1;
            btnCadastrarMais.Text = "Cadastrar mais";
            btnCadastrarMais.Click += btnCadastrarMais_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(190, 80);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(120, 35);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.Click += btnSair_Click;
            // 
            // FrmConfirmacao
            // 
            ClientSize = new Size(360, 150);
            Controls.Add(lblMensagem);
            Controls.Add(btnCadastrarMais);
            Controls.Add(btnSair);
            Name = "FrmConfirmacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confirmação";
            Load += FrmConfirmacao_Load;
            ResumeLayout(false);
        }
    }
}