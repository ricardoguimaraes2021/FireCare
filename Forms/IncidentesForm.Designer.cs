namespace FireCare
{
    partial class IncidentesForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            listViewOcorrencias = new ListView();
            ID = new ColumnHeader();
            Localizacao = new ColumnHeader();
            Severidade = new ColumnHeader();
            Estado = new ColumnHeader();
            Tipo = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            btnAdicionarOcorrencia = new Button();
            txtDescricao = new TextBox();
            txtLocalizacao = new TextBox();
            txtLatitude = new TextBox();
            txtLongitude = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelHora = new Label();
            comboSeveridade = new ComboBox();
            comboEstado = new ComboBox();
            comboTipo = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnExcluirOcorrencia = new Button();
            btnEditarOcorrencia = new Button();
            label8 = new Label();
            timerHora = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Incidentes";
            // 
            // listViewOcorrencias
            // 
            listViewOcorrencias.Columns.AddRange(new ColumnHeader[] { ID, Localizacao, Severidade, Estado, Tipo, columnHeader1 });
            listViewOcorrencias.Location = new Point(82, 39);
            listViewOcorrencias.Name = "listViewOcorrencias";
            listViewOcorrencias.Size = new Size(837, 377);
            listViewOcorrencias.TabIndex = 1;
            listViewOcorrencias.UseCompatibleStateImageBehavior = false;
            listViewOcorrencias.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            // 
            // Localizacao
            // 
            Localizacao.Text = "Localizaçao";
            // 
            // Severidade
            // 
            Severidade.Text = "Severidade";
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            // 
            // Tipo
            // 
            Tipo.Text = "Tipo";
            // 
            // btnAdicionarOcorrencia
            // 
            btnAdicionarOcorrencia.Location = new Point(128, 639);
            btnAdicionarOcorrencia.Name = "btnAdicionarOcorrencia";
            btnAdicionarOcorrencia.Size = new Size(75, 23);
            btnAdicionarOcorrencia.TabIndex = 2;
            btnAdicionarOcorrencia.Text = "Adicionar";
            btnAdicionarOcorrencia.UseVisualStyleBackColor = true;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(101, 452);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(308, 23);
            txtDescricao.TabIndex = 3;
            // 
            // txtLocalizacao
            // 
            txtLocalizacao.Location = new Point(107, 503);
            txtLocalizacao.Name = "txtLocalizacao";
            txtLocalizacao.Size = new Size(100, 23);
            txtLocalizacao.TabIndex = 4;
            // 
            // txtLatitude
            // 
            txtLatitude.Location = new Point(106, 556);
            txtLatitude.Name = "txtLatitude";
            txtLatitude.Size = new Size(100, 23);
            txtLatitude.TabIndex = 5;
            // 
            // txtLongitude
            // 
            txtLongitude.Location = new Point(107, 598);
            txtLongitude.Name = "txtLongitude";
            txtLongitude.Size = new Size(100, 23);
            txtLongitude.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 506);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 7;
            label2.Text = "Localização";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 567);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 8;
            label3.Text = "Latitude";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 606);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 9;
            label4.Text = "Longitude";
            // 
            // labelHora
            // 
            labelHora.AutoSize = true;
            labelHora.Location = new Point(18, 39);
            labelHora.Name = "labelHora";
            labelHora.Size = new Size(33, 15);
            labelHora.TabIndex = 10;
            labelHora.Text = "Hora";
            // 
            // comboSeveridade
            // 
            comboSeveridade.FormattingEnabled = true;
            comboSeveridade.Location = new Point(447, 512);
            comboSeveridade.Name = "comboSeveridade";
            comboSeveridade.Size = new Size(121, 23);
            comboSeveridade.TabIndex = 11;
            // 
            // comboEstado
            // 
            comboEstado.FormattingEnabled = true;
            comboEstado.Location = new Point(451, 568);
            comboEstado.Name = "comboEstado";
            comboEstado.Size = new Size(121, 23);
            comboEstado.TabIndex = 12;
            // 
            // comboTipo
            // 
            comboTipo.FormattingEnabled = true;
            comboTipo.Location = new Point(451, 616);
            comboTipo.Name = "comboTipo";
            comboTipo.Size = new Size(121, 23);
            comboTipo.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(414, 619);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 14;
            label5.Text = "Tipo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(380, 520);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 15;
            label6.Text = "Seviridade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(403, 576);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 16;
            label7.Text = "Estado";
            // 
            // btnExcluirOcorrencia
            // 
            btnExcluirOcorrencia.Location = new Point(255, 653);
            btnExcluirOcorrencia.Name = "btnExcluirOcorrencia";
            btnExcluirOcorrencia.Size = new Size(75, 23);
            btnExcluirOcorrencia.TabIndex = 18;
            btnExcluirOcorrencia.Text = "Eliminar";
            btnExcluirOcorrencia.UseVisualStyleBackColor = true;
            // 
            // btnEditarOcorrencia
            // 
            btnEditarOcorrencia.Location = new Point(378, 661);
            btnEditarOcorrencia.Name = "btnEditarOcorrencia";
            btnEditarOcorrencia.Size = new Size(75, 23);
            btnEditarOcorrencia.TabIndex = 19;
            btnEditarOcorrencia.Text = "Editar";
            btnEditarOcorrencia.UseVisualStyleBackColor = true;
            btnEditarOcorrencia.Click += btnEditarOcorrencia_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(37, 455);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 20;
            label8.Text = "Descriçao";
            // 
            // IncidentesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1398, 696);
            Controls.Add(label8);
            Controls.Add(btnEditarOcorrencia);
            Controls.Add(btnExcluirOcorrencia);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboTipo);
            Controls.Add(comboEstado);
            Controls.Add(comboSeveridade);
            Controls.Add(labelHora);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtLongitude);
            Controls.Add(txtLatitude);
            Controls.Add(txtLocalizacao);
            Controls.Add(txtDescricao);
            Controls.Add(btnAdicionarOcorrencia);
            Controls.Add(listViewOcorrencias);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IncidentesForm";
            Text = "IncidentesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listViewOcorrencias;
        private Button btnAdicionarOcorrencia;
        private TextBox txtDescricao;
        private TextBox txtLocalizacao;
        private TextBox txtLatitude;
        private TextBox txtLongitude;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelHora;
        private ComboBox comboSeveridade;
        private ComboBox comboEstado;
        private ComboBox comboTipo;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnExcluirOcorrencia;
        private Button btnEditarOcorrencia;
        private ColumnHeader ID;
        private ColumnHeader Localizacao;
        private ColumnHeader Severidade;
        private ColumnHeader Estado;
        private ColumnHeader Tipo;
        private ColumnHeader columnHeader1;
        private Label label8;
        private System.Windows.Forms.Timer timerHora;
    }
}