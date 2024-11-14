namespace FireCare
{
    partial class EquipamentosForm
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
            listViewEquipamentos = new ListView();
            Nome = new ColumnHeader();
            Categoria = new ColumnHeader();
            Quantidade = new ColumnHeader();
            Origem = new ColumnHeader();
            Estado = new ColumnHeader();
            txtNomeEquipamento = new TextBox();
            label2 = new Label();
            comboCategoria = new ComboBox();
            txtQuantidade = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboOrigem = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            comboEstado = new ComboBox();
            btnAdicionarEquipamento = new Button();
            btnEditarEquipamento = new Button();
            btnExcluirEquipamento = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Equipamentos";
            // 
            // listViewEquipamentos
            // 
            listViewEquipamentos.Columns.AddRange(new ColumnHeader[] { Nome, Categoria, Quantidade, Origem, Estado });
            listViewEquipamentos.Location = new Point(54, 42);
            listViewEquipamentos.Name = "listViewEquipamentos";
            listViewEquipamentos.Size = new Size(679, 146);
            listViewEquipamentos.TabIndex = 1;
            listViewEquipamentos.UseCompatibleStateImageBehavior = false;
            listViewEquipamentos.View = View.Details;
            listViewEquipamentos.SelectedIndexChanged += listViewEquipamentos_SelectedIndexChanged;
            // 
            // Nome
            // 
            Nome.Text = "Nome";
            // 
            // Categoria
            // 
            Categoria.Text = "Categoria";
            // 
            // Quantidade
            // 
            Quantidade.Text = "Quantidade";
            // 
            // Origem
            // 
            Origem.Text = "Origem";
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            // 
            // txtNomeEquipamento
            // 
            txtNomeEquipamento.Location = new Point(125, 232);
            txtNomeEquipamento.Name = "txtNomeEquipamento";
            txtNomeEquipamento.Size = new Size(100, 23);
            txtNomeEquipamento.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 235);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // comboCategoria
            // 
            comboCategoria.FormattingEnabled = true;
            comboCategoria.Location = new Point(128, 283);
            comboCategoria.Name = "comboCategoria";
            comboCategoria.Size = new Size(121, 23);
            comboCategoria.TabIndex = 4;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(130, 338);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 286);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 6;
            label3.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 346);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 7;
            label4.Text = "Quantidade";
            // 
            // comboOrigem
            // 
            comboOrigem.FormattingEnabled = true;
            comboOrigem.Location = new Point(402, 235);
            comboOrigem.Name = "comboOrigem";
            comboOrigem.Size = new Size(121, 23);
            comboOrigem.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(349, 240);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 9;
            label5.Text = "Origem";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(346, 296);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 10;
            label6.Text = "Estado";
            // 
            // comboEstado
            // 
            comboEstado.FormattingEnabled = true;
            comboEstado.Location = new Point(402, 293);
            comboEstado.Name = "comboEstado";
            comboEstado.Size = new Size(121, 23);
            comboEstado.TabIndex = 11;
            // 
            // btnAdicionarEquipamento
            // 
            btnAdicionarEquipamento.Location = new Point(92, 396);
            btnAdicionarEquipamento.Name = "btnAdicionarEquipamento";
            btnAdicionarEquipamento.Size = new Size(75, 23);
            btnAdicionarEquipamento.TabIndex = 12;
            btnAdicionarEquipamento.Text = "Adicionar";
            btnAdicionarEquipamento.UseVisualStyleBackColor = true;
            btnAdicionarEquipamento.Click += btnAdicionarEquipamento_Click;
            // 
            // btnEditarEquipamento
            // 
            btnEditarEquipamento.Location = new Point(271, 396);
            btnEditarEquipamento.Name = "btnEditarEquipamento";
            btnEditarEquipamento.Size = new Size(75, 23);
            btnEditarEquipamento.TabIndex = 13;
            btnEditarEquipamento.Text = "Editar";
            btnEditarEquipamento.UseVisualStyleBackColor = true;
            btnEditarEquipamento.Click += btnEditarEquipamento_Click;
            // 
            // btnExcluirEquipamento
            // 
            btnExcluirEquipamento.Location = new Point(448, 396);
            btnExcluirEquipamento.Name = "btnExcluirEquipamento";
            btnExcluirEquipamento.Size = new Size(75, 23);
            btnExcluirEquipamento.TabIndex = 14;
            btnExcluirEquipamento.Text = "Eliminar";
            btnExcluirEquipamento.UseVisualStyleBackColor = true;
            btnExcluirEquipamento.Click += btnExcluirEquipamento_Click;
            // 
            // EquipamentosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExcluirEquipamento);
            Controls.Add(btnEditarEquipamento);
            Controls.Add(btnAdicionarEquipamento);
            Controls.Add(comboEstado);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboOrigem);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtQuantidade);
            Controls.Add(comboCategoria);
            Controls.Add(label2);
            Controls.Add(txtNomeEquipamento);
            Controls.Add(listViewEquipamentos);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EquipamentosForm";
            Text = "EquipamentosForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listViewEquipamentos;
        private TextBox txtNomeEquipamento;
        private Label label2;
        private ComboBox comboCategoria;
        private TextBox txtQuantidade;
        private Label label3;
        private Label label4;
        private ComboBox comboOrigem;
        private Label label5;
        private Label label6;
        private ComboBox comboEstado;
        private Button btnAdicionarEquipamento;
        private Button btnEditarEquipamento;
        private ColumnHeader Nome;
        private ColumnHeader Categoria;
        private ColumnHeader Quantidade;
        private ColumnHeader Origem;
        private ColumnHeader Estado;
        private Button btnExcluirEquipamento;
    }
}