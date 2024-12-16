using FireCare.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FireCare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void btn_painel_Click(object sender, EventArgs e)
        {
            loadform(new PainelForm());
        }

        private void btn_incidentes_Click(object sender, EventArgs e)
        {
            loadform(new IncidentesForm());
        }

        private void btn_profissionais_Click(object sender, EventArgs e)
        {
            loadform(new ProfissionaisForm());
        }

        private void btn_equipamento_Click(object sender, EventArgs e)
        {
            loadform(new EquipamentosForm());
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_exit_MouseEnter(object sender, EventArgs e)
        {
            btn_exit.BackColor = Color.Red;
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.BackColor = SystemColors.Control;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Tem certeza de que deseja sair?", "Confirmar Logout", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // Fecha o formulário principal
                this.Hide();

                // Abre o LoginForm novamente
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();

                // Fecha o formulário atual após a volta ao LoginForm
                this.Close();
            }
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
