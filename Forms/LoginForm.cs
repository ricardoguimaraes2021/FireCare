using System;
using System.Windows.Forms;
using FireCare.Services;
using System.Security.Cryptography;
using System.Text;

namespace FireCare.Forms
{
    public partial class LoginForm : Form
    {
        private readonly ProfissionalServico profissionalService = new ProfissionalServico();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = EncriptarSenha(txtSenha.Text); // Encripta a senha antes de verificar

            // Exibe as credenciais digitadas e a senha encriptada para verificação
            MessageBox.Show("Email digitado: " + email + "\nSenha encriptada: " + senha, "Debug - Credenciais");

            // Tenta autenticar o usuário com as credenciais fornecidas
            var profissional = profissionalService.Autenticar(email, senha);

            if (profissional != null)
            {
                // Login bem-sucedido, abrir o formulário principal
                this.Hide();
                Form1 formPrincipal = new Form1();
                formPrincipal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciais incorretas.");
            }
        }

        private string EncriptarSenha(string senha)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                var builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
