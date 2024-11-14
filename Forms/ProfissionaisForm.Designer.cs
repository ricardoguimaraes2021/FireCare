namespace FireCare
{
    partial class ProfissionaisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            lbl_nome = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEndereco = new TextBox();
            label4 = new Label();
            comboTipoSanguineo = new ComboBox();
            dateTimePickerDataNascimento = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            label7 = new Label();
            comboGenero = new ComboBox();
            label8 = new Label();
            txtEmail = new TextBox();
            label9 = new Label();
            comboCargo = new ComboBox();
            btn_adicionar_profissional = new Button();
            label10 = new Label();
            txtSenha = new TextBox();
            groupBox1 = new GroupBox();
            listViewProfissionais = new ListView();
            coluna_id = new ColumnHeader();
            coluna_nome = new ColumnHeader();
            coluna_cargo = new ColumnHeader();
            coluna_email = new ColumnHeader();
            coluna_disponivel = new ColumnHeader();
            btn_atualizar_profissional = new Button();
            btn_eliminar_profissional = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Profissionais";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(93, 51);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 1;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(93, 104);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 2;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Location = new Point(11, 58);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(40, 15);
            lbl_nome.TabIndex = 3;
            lbl_nome.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 112);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "Telemóvel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 164);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Endereço";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(93, 157);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(100, 23);
            txtEndereco.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(294, 30);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 7;
            label4.Text = "Tipo Sanguinio";
            // 
            // comboTipoSanguineo
            // 
            comboTipoSanguineo.FormattingEnabled = true;
            comboTipoSanguineo.Items.AddRange(new object[] { " APositivo", " ANegativo", " BPositivo", " BNegativo", " ABPositivo", " ABNegativo", " OPositivo", " ONegativo" });
            comboTipoSanguineo.Location = new Point(387, 22);
            comboTipoSanguineo.Name = "comboTipoSanguineo";
            comboTipoSanguineo.Size = new Size(121, 23);
            comboTipoSanguineo.TabIndex = 10;
            // 
            // dateTimePickerDataNascimento
            // 
            dateTimePickerDataNascimento.Location = new Point(701, 27);
            dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            dateTimePickerDataNascimento.Size = new Size(200, 23);
            dateTimePickerDataNascimento.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(597, 33);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 12;
            label5.Text = "Data Nascimento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 22);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 13;
            label6.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(93, 22);
            txtId.Name = "txtId";
            txtId.Size = new Size(51, 23);
            txtId.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(600, 82);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 15;
            label7.Text = "Género";
            // 
            // comboGenero
            // 
            comboGenero.FormattingEnabled = true;
            comboGenero.Items.AddRange(new object[] { "Masculino", "Feminino" });
            comboGenero.Location = new Point(651, 79);
            comboGenero.Name = "comboGenero";
            comboGenero.Size = new Size(121, 23);
            comboGenero.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(606, 142);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 17;
            label8.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(651, 139);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(282, 114);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 19;
            label9.Text = "Cargo";
            // 
            // comboCargo
            // 
            comboCargo.FormattingEnabled = true;
            comboCargo.Items.AddRange(new object[] { "Bombeiro", "Medico", "Enfermeiro", "Tecnico" });
            comboCargo.Location = new Point(327, 112);
            comboCargo.Name = "comboCargo";
            comboCargo.Size = new Size(121, 23);
            comboCargo.TabIndex = 20;
            // 
            // btn_adicionar_profissional
            // 
            btn_adicionar_profissional.Location = new Point(66, 683);
            btn_adicionar_profissional.Name = "btn_adicionar_profissional";
            btn_adicionar_profissional.Size = new Size(139, 30);
            btn_adicionar_profissional.TabIndex = 21;
            btn_adicionar_profissional.Text = "Adicionar Profissional";
            btn_adicionar_profissional.UseVisualStyleBackColor = true;
            btn_adicionar_profissional.Click += btn_adicionar_profissional_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(294, 83);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 22;
            label10.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(348, 75);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 23;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboCargo);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(comboGenero);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtEndereco);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(dateTimePickerDataNascimento);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(lbl_nome);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboTipoSanguineo);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(26, 380);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(981, 294);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            // 
            // listViewProfissionais
            // 
            listViewProfissionais.Columns.AddRange(new ColumnHeader[] { coluna_id, coluna_nome, coluna_cargo, coluna_email, coluna_disponivel });
            listViewProfissionais.Location = new Point(66, 44);
            listViewProfissionais.Name = "listViewProfissionais";
            listViewProfissionais.Size = new Size(1003, 299);
            listViewProfissionais.TabIndex = 25;
            listViewProfissionais.UseCompatibleStateImageBehavior = false;
            listViewProfissionais.View = View.Details;
            listViewProfissionais.SelectedIndexChanged += listViewProfissionais_SelectedIndexChanged;
            // 
            // coluna_id
            // 
            coluna_id.Text = "ID";
            coluna_id.Width = 50;
            // 
            // coluna_nome
            // 
            coluna_nome.Text = "Nome";
            coluna_nome.Width = 150;
            // 
            // coluna_cargo
            // 
            coluna_cargo.Text = "Cargo";
            coluna_cargo.Width = 100;
            // 
            // coluna_email
            // 
            coluna_email.Text = "Email";
            coluna_email.Width = 200;
            // 
            // coluna_disponivel
            // 
            coluna_disponivel.Text = "Disponível";
            coluna_disponivel.Width = 80;
            // 
            // btn_atualizar_profissional
            // 
            btn_atualizar_profissional.Location = new Point(230, 683);
            btn_atualizar_profissional.Name = "btn_atualizar_profissional";
            btn_atualizar_profissional.Size = new Size(160, 30);
            btn_atualizar_profissional.TabIndex = 26;
            btn_atualizar_profissional.Text = "Atualizar Profissional";
            btn_atualizar_profissional.UseVisualStyleBackColor = true;
            btn_atualizar_profissional.Click += btn_atualizar_profissional_Click;
            // 
            // btn_eliminar_profissional
            // 
            btn_eliminar_profissional.Location = new Point(396, 683);
            btn_eliminar_profissional.Name = "btn_eliminar_profissional";
            btn_eliminar_profissional.Size = new Size(160, 30);
            btn_eliminar_profissional.TabIndex = 27;
            btn_eliminar_profissional.Text = "Eliminar Profissional";
            btn_eliminar_profissional.Click += btn_eliminar_profissional_Click;
            // 
            // ProfissionaisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1223, 784);
            Controls.Add(btn_eliminar_profissional);
            Controls.Add(btn_atualizar_profissional);
            Controls.Add(listViewProfissionais);
            Controls.Add(groupBox1);
            Controls.Add(btn_adicionar_profissional);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProfissionaisForm";
            Text = "ProfissionaisForm";
            Load += ProfissionaisForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private Label lbl_nome;
        private Label label2;
        private Label label3;
        private TextBox txtEndereco;
        private Label label4;
        private ComboBox comboTipoSanguineo;
        private DateTimePicker dateTimePickerDataNascimento;
        private Label label5;
        private Label label6;
        private TextBox txtId;
        private Label label7;
        private ComboBox comboGenero;
        private Label label8;
        private TextBox txtEmail;
        private Label label9;
        private ComboBox comboCargo;
        private Button btn_adicionar_profissional;
        private Label label10;
        private TextBox txtSenha;
        private GroupBox groupBox1;
        private ListView listViewProfissionais;
        private ColumnHeader coluna_id;
        private ColumnHeader coluna_nome;
        private ColumnHeader coluna_cargo;
        private ColumnHeader coluna_email;
        private ColumnHeader coluna_disponivel;
        private Button btn_atualizar_profissional;
        private Button btn_eliminar_profissional;
    }
}