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
    }
}
