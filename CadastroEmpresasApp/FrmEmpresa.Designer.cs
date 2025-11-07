using System.Drawing;
using System.Windows.Forms;

namespace CadastroEmpresasApp
{
    partial class FrmEmpresa
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblRazaoSocial = new Label();
            lblNomeFantasia = new Label();
            lblCNPJ = new Label();
            lblSegmento = new Label();
            lblDataCadastro = new Label();
            lblEnderecoId = new Label();
            txtRazaoSocial = new TextBox();
            txtNomeFantasia = new TextBox();
            txtCNPJ = new TextBox();
            txtSegmento = new TextBox();
            txtEnderecoId = new TextBox();
            dtCadastro = new DateTimePicker();
            btnSalvar = new Button();
            btnLimpar = new Button();
            SuspendLayout();

            // Labels
            lblRazaoSocial.Font = new Font("Segoe UI", 10F);
            lblRazaoSocial.ForeColor = Color.DarkBlue;
            lblRazaoSocial.Location = new Point(30, 34);
            lblRazaoSocial.Name = "lblRazaoSocial";
            lblRazaoSocial.Size = new Size(120, 23);
            lblRazaoSocial.TabIndex = 13;
            lblRazaoSocial.Text = "Razão Social";

            lblNomeFantasia.Font = new Font("Segoe UI", 10F);
            lblNomeFantasia.ForeColor = Color.DarkBlue;
            lblNomeFantasia.Location = new Point(30, 68);
            lblNomeFantasia.Name = "lblNomeFantasia";
            lblNomeFantasia.Size = new Size(120, 23);
            lblNomeFantasia.TabIndex = 12;
            lblNomeFantasia.Text = "Nome Fantasia";

            lblCNPJ.Font = new Font("Segoe UI", 10F);
            lblCNPJ.ForeColor = Color.DarkBlue;
            lblCNPJ.Location = new Point(30, 102);
            lblCNPJ.Name = "lblCNPJ";
            lblCNPJ.Size = new Size(120, 23);
            lblCNPJ.TabIndex = 11;
            lblCNPJ.Text = "CNPJ";

            lblSegmento.Font = new Font("Segoe UI", 10F);
            lblSegmento.ForeColor = Color.DarkBlue;
            lblSegmento.Location = new Point(30, 136);
            lblSegmento.Name = "lblSegmento";
            lblSegmento.Size = new Size(120, 23);
            lblSegmento.TabIndex = 10;
            lblSegmento.Text = "Segmento";

            lblDataCadastro.Font = new Font("Segoe UI", 10F);
            lblDataCadastro.ForeColor = Color.DarkBlue;
            lblDataCadastro.Location = new Point(30, 170);
            lblDataCadastro.Name = "lblDataCadastro";
            lblDataCadastro.Size = new Size(120, 23);
            lblDataCadastro.TabIndex = 9;
            lblDataCadastro.Text = "Data de Cadastro";

            lblEnderecoId.Font = new Font("Segoe UI", 10F);
            lblEnderecoId.ForeColor = Color.DarkBlue;
            lblEnderecoId.Location = new Point(30, 204);
            lblEnderecoId.Name = "lblEnderecoId";
            lblEnderecoId.Size = new Size(120, 23);
            lblEnderecoId.TabIndex = 8;
            lblEnderecoId.Text = "ID Endereço";

            // TextBoxes
            txtRazaoSocial.Font = new Font("Segoe UI", 10F);
            txtRazaoSocial.Location = new Point(160, 34);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(350, 25);
            txtRazaoSocial.TabIndex = 7;

            txtNomeFantasia.Font = new Font("Segoe UI", 10F);
            txtNomeFantasia.Location = new Point(160, 68);
            txtNomeFantasia.Name = "txtNomeFantasia";
            txtNomeFantasia.Size = new Size(350, 25);
            txtNomeFantasia.TabIndex = 6;

            txtCNPJ.Font = new Font("Segoe UI", 10F);
            txtCNPJ.Location = new Point(160, 102);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(200, 25);
            txtCNPJ.TabIndex = 5;

            txtSegmento.Font = new Font("Segoe UI", 10F);
            txtSegmento.Location = new Point(160, 136);
            txtSegmento.Name = "txtSegmento";
            txtSegmento.Size = new Size(250, 25);
            txtSegmento.TabIndex = 4;

            txtEnderecoId.Font = new Font("Segoe UI", 10F);
            txtEnderecoId.Location = new Point(160, 204);
            txtEnderecoId.Name = "txtEnderecoId";
            txtEnderecoId.Size = new Size(100, 25);
            txtEnderecoId.TabIndex = 3;

            // DateTimePicker
            dtCadastro.Font = new Font("Segoe UI", 10F);
            dtCadastro.Format = DateTimePickerFormat.Short;
            dtCadastro.Location = new Point(160, 170);
            dtCadastro.Name = "dtCadastro";
            dtCadastro.Size = new Size(150, 25);
            dtCadastro.TabIndex = 2;

            // Buttons
            btnSalvar.BackColor = Color.LightGreen;
            btnSalvar.Font = new Font("Segoe UI", 10F);
            btnSalvar.Location = new Point(160, 261);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(80, 34);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;

            btnLimpar.BackColor = Color.LightCoral;
            btnLimpar.Font = new Font("Segoe UI", 10F);
            btnLimpar.Location = new Point(260, 261);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(80, 34);
            btnLimpar.TabIndex = 0;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;

            // Form
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(584, 409);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(dtCadastro);
            Controls.Add(txtEnderecoId);
            Controls.Add(txtSegmento);
            Controls.Add(txtCNPJ);
            Controls.Add(txtNomeFantasia);
            Controls.Add(txtRazaoSocial);
            Controls.Add(lblEnderecoId);
            Controls.Add(lblDataCadastro);
            Controls.Add(lblSegmento);
            Controls.Add(lblCNPJ);
            Controls.Add(lblNomeFantasia);
            Controls.Add(lblRazaoSocial);
            Font = new Font("Segoe UI", 10F);
            Name = "FrmEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Empresa";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblRazaoSocial;
        private Label lblNomeFantasia;
        private Label lblCNPJ;
        private Label lblSegmento;
        private Label lblDataCadastro;
        private Label lblEnderecoId;
        private TextBox txtRazaoSocial;
        private TextBox txtNomeFantasia;
        private TextBox txtCNPJ;
        private TextBox txtSegmento;
        private TextBox txtEnderecoId;
        private DateTimePicker dtCadastro;
        private Button btnSalvar;
        private Button btnLimpar;
    }
}