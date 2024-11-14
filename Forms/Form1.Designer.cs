namespace FireCare
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnl_sidebar = new Panel();
            btnLogout = new Button();
            btn_exit = new Button();
            pictureBox1 = new PictureBox();
            lbl_titulo = new Label();
            btn_equipamento = new Button();
            btn_painel = new Button();
            btn_profissionais = new Button();
            btn_incidentes = new Button();
            mainpanel = new Panel();
            pnl_sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnl_sidebar
            // 
            pnl_sidebar.BackColor = Color.FromArgb(224, 224, 224);
            pnl_sidebar.Controls.Add(btnLogout);
            pnl_sidebar.Controls.Add(btn_exit);
            pnl_sidebar.Controls.Add(pictureBox1);
            pnl_sidebar.Controls.Add(lbl_titulo);
            pnl_sidebar.Controls.Add(btn_equipamento);
            pnl_sidebar.Controls.Add(btn_painel);
            pnl_sidebar.Controls.Add(btn_profissionais);
            pnl_sidebar.Controls.Add(btn_incidentes);
            pnl_sidebar.Dock = DockStyle.Left;
            pnl_sidebar.Location = new Point(0, 0);
            pnl_sidebar.Name = "pnl_sidebar";
            pnl_sidebar.Size = new Size(200, 678);
            pnl_sidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(56, 536);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(116, 23);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = SystemColors.ActiveBorder;
            btn_exit.BackgroundImageLayout = ImageLayout.Center;
            btn_exit.Location = new Point(39, 610);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(53, 40);
            btn_exit.TabIndex = 0;
            btn_exit.Text = "X";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            btn_exit.MouseEnter += btn_exit_MouseEnter;
            btn_exit.MouseLeave += btn_exit_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titulo.Location = new Point(63, 14);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(130, 40);
            lbl_titulo.TabIndex = 4;
            lbl_titulo.Text = "FireCare";
            // 
            // btn_equipamento
            // 
            btn_equipamento.Font = new Font("Verdana", 15.75F);
            btn_equipamento.Image = (Image)resources.GetObject("btn_equipamento.Image");
            btn_equipamento.ImageAlign = ContentAlignment.TopCenter;
            btn_equipamento.Location = new Point(0, 416);
            btn_equipamento.Name = "btn_equipamento";
            btn_equipamento.Size = new Size(200, 90);
            btn_equipamento.TabIndex = 3;
            btn_equipamento.Text = "Equipamentos";
            btn_equipamento.UseVisualStyleBackColor = true;
            btn_equipamento.Click += btn_equipamento_Click;
            // 
            // btn_painel
            // 
            btn_painel.Font = new Font("Verdana", 15.75F);
            btn_painel.Image = (Image)resources.GetObject("btn_painel.Image");
            btn_painel.ImageAlign = ContentAlignment.TopCenter;
            btn_painel.Location = new Point(0, 128);
            btn_painel.Name = "btn_painel";
            btn_painel.Size = new Size(200, 90);
            btn_painel.TabIndex = 0;
            btn_painel.Text = "Painel";
            btn_painel.UseVisualStyleBackColor = true;
            btn_painel.Click += btn_painel_Click;
            // 
            // btn_profissionais
            // 
            btn_profissionais.Font = new Font("Verdana", 15.75F);
            btn_profissionais.Image = (Image)resources.GetObject("btn_profissionais.Image");
            btn_profissionais.ImageAlign = ContentAlignment.TopCenter;
            btn_profissionais.Location = new Point(0, 320);
            btn_profissionais.Name = "btn_profissionais";
            btn_profissionais.Size = new Size(200, 90);
            btn_profissionais.TabIndex = 2;
            btn_profissionais.Text = "Profissionais";
            btn_profissionais.UseVisualStyleBackColor = true;
            btn_profissionais.Click += btn_profissionais_Click;
            // 
            // btn_incidentes
            // 
            btn_incidentes.Font = new Font("Verdana", 15.75F);
            btn_incidentes.Image = (Image)resources.GetObject("btn_incidentes.Image");
            btn_incidentes.ImageAlign = ContentAlignment.TopCenter;
            btn_incidentes.Location = new Point(0, 224);
            btn_incidentes.Name = "btn_incidentes";
            btn_incidentes.Size = new Size(200, 90);
            btn_incidentes.TabIndex = 1;
            btn_incidentes.Text = "Incidentes";
            btn_incidentes.UseVisualStyleBackColor = true;
            btn_incidentes.Click += btn_incidentes_Click;
            // 
            // mainpanel
            // 
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(200, 0);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(836, 678);
            mainpanel.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 678);
            Controls.Add(mainpanel);
            Controls.Add(pnl_sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            pnl_sidebar.ResumeLayout(false);
            pnl_sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_sidebar;
        private Button btn_painel;
        private Label lbl_titulo;
        private Button btn_equipamento;
        private Button btn_profissionais;
        private Button btn_incidentes;
        private PictureBox pictureBox1;
        private Button btn_exit;
        private Panel mainpanel;
        private Button btnLogout;
    }
}
