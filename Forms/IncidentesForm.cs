using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FireCare.Models;
using FireCare.Services;

namespace FireCare
{
    public partial class IncidentesForm : Form
    {
        private readonly OcorrenciaServico ocorrenciaService = new OcorrenciaServico();

        public IncidentesForm()
        {
            InitializeComponent();
            this.Load += IncidentesForm_Load;
        }

        private void IncidentesForm_Load(object sender, EventArgs e)
        {
            CarregarSeveridades();
            CarregarEstados();
            CarregarTipos();
            CarregarOcorrenciasNaListView();
            ConfigurarEstadoInicialDosBotoes();
            ConfigurarTimerHora();
        }

        private void CarregarSeveridades()
        {
            comboSeveridade.Items.Clear();
            comboSeveridade.Items.AddRange(Enum.GetNames(typeof(SeveridadeOcorrencia)));
            comboSeveridade.SelectedIndex = 0;
        }

        private void CarregarEstados()
        {
            comboEstado.Items.Clear();
            comboEstado.Items.AddRange(Enum.GetNames(typeof(EstadoOcorrencia)));
            comboEstado.SelectedIndex = 0;
        }

        private void CarregarTipos()
        {
            comboTipo.Items.Clear();
            comboTipo.Items.AddRange(Enum.GetNames(typeof(TipodeOcorrencia)));
            comboTipo.SelectedIndex = 0;
        }

        private void ConfigurarTimerHora()
        {
            var timerHora = new System.Windows.Forms.Timer();
            timerHora.Interval = 1000; // Atualiza a cada segundo
            timerHora.Tick += (s, e) => labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
            timerHora.Start();
        }

        private void CarregarOcorrenciasNaListView()
        {
            listViewOcorrencias.Items.Clear();
            List<Ocorrencia> ocorrencias = ocorrenciaService.ObterTodasOcorrencias();

            foreach (var ocorrencia in ocorrencias)
            {
                ListViewItem item = new ListViewItem(ocorrencia.Id.ToString()); // ID da ocorrência
                item.SubItems.Add(ocorrencia.Descricao);
                item.SubItems.Add(ocorrencia.Localizacao);
                item.SubItems.Add(ocorrencia.Latitude);
                item.SubItems.Add(ocorrencia.Longitude);
                item.SubItems.Add(ocorrencia.DataHora.ToString("yyyy-MM-dd HH:mm"));
                item.SubItems.Add(ocorrencia.Severidade.ToString());
                item.SubItems.Add(ocorrencia.Estado.ToString());
                item.SubItems.Add(ocorrencia.Tipo.ToString());

                listViewOcorrencias.Items.Add(item);
            }
        }

        private void ConfigurarEstadoInicialDosBotoes()
        {
            btnAdicionarOcorrencia.Enabled = true;
            btnEditarOcorrencia.Enabled = false;
            btnExcluirOcorrencia.Enabled = false;
        }

        private void listViewOcorrencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOcorrencias.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewOcorrencias.SelectedItems[0];
                int ocorrenciaId = int.Parse(item.Text);

                Ocorrencia ocorrencia = ocorrenciaService.ObterOcorrenciaPorId(ocorrenciaId);

                if (ocorrencia != null)
                {
                    txtDescricao.Text = ocorrencia.Descricao;
                    txtLocalizacao.Text = ocorrencia.Localizacao;
                    txtLatitude.Text = ocorrencia.Latitude;
                    txtLongitude.Text = ocorrencia.Longitude;
                    comboSeveridade.SelectedItem = ocorrencia.Severidade.ToString();
                    comboEstado.SelectedItem = ocorrencia.Estado.ToString();
                    comboTipo.SelectedItem = ocorrencia.Tipo.ToString();

                    btnAdicionarOcorrencia.Enabled = false;
                    btnEditarOcorrencia.Enabled = true;
                    btnExcluirOcorrencia.Enabled = true;
                }
            }
            else
            {
                ConfigurarEstadoInicialDosBotoes();
            }
        }

        private void btnAdicionarOcorrencia_Click(object sender, EventArgs e)
        {
            try
            {
                var ocorrencia = new Ocorrencia
                {
                    Descricao = txtDescricao.Text,
                    Localizacao = txtLocalizacao.Text,
                    Latitude = txtLatitude.Text,
                    Longitude = txtLongitude.Text,
                    DataHora = DateTime.Now,
                    Severidade = (SeveridadeOcorrencia)Enum.Parse(typeof(SeveridadeOcorrencia), comboSeveridade.SelectedItem.ToString()),
                    Estado = (EstadoOcorrencia)Enum.Parse(typeof(EstadoOcorrencia), comboEstado.SelectedItem.ToString()),
                    Tipo = (TipodeOcorrencia)Enum.Parse(typeof(TipodeOcorrencia), comboTipo.SelectedItem.ToString())
                };

                if (ocorrenciaService.AdicionarOcorrencia(ocorrencia))
                {
                    MessageBox.Show("Ocorrência adicionada com sucesso!");
                    LimparCampos();
                    CarregarOcorrenciasNaListView();
                }
                else
                {
                    MessageBox.Show("Erro ao adicionar ocorrência.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar os dados: " + ex.Message);
            }
        }

        private void btnEditarOcorrencia_Click(object sender, EventArgs e)
        {
            if (listViewOcorrencias.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewOcorrencias.SelectedItems[0];
                int ocorrenciaId = int.Parse(item.Text);

                var ocorrencia = new Ocorrencia
                {
                    Id = ocorrenciaId,
                    Descricao = txtDescricao.Text,
                    Localizacao = txtLocalizacao.Text,
                    Latitude = txtLatitude.Text,
                    Longitude = txtLongitude.Text,
                    DataHora = DateTime.Now,
                    Severidade = (SeveridadeOcorrencia)Enum.Parse(typeof(SeveridadeOcorrencia), comboSeveridade.SelectedItem.ToString()),
                    Estado = (EstadoOcorrencia)Enum.Parse(typeof(EstadoOcorrencia), comboEstado.SelectedItem.ToString()),
                    Tipo = (TipodeOcorrencia)Enum.Parse(typeof(TipodeOcorrencia), comboTipo.SelectedItem.ToString())
                };

                if (ocorrenciaService.AtualizarOcorrencia(ocorrencia))
                {
                    MessageBox.Show("Ocorrência atualizada com sucesso!");
                    LimparCampos();
                    CarregarOcorrenciasNaListView();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar ocorrência.");
                }
            }
        }

        private void btnExcluirOcorrencia_Click(object sender, EventArgs e)
        {
            if (listViewOcorrencias.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewOcorrencias.SelectedItems[0];
                int ocorrenciaId = int.Parse(item.Text);

                var confirmResult = MessageBox.Show("Tem certeza de que deseja excluir esta ocorrência?", "Confirmação", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    if (ocorrenciaService.EliminarOcorrencia(ocorrenciaId))
                    {
                        MessageBox.Show("Ocorrência excluída com sucesso!");
                        LimparCampos();
                        CarregarOcorrenciasNaListView();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir ocorrência.");
                    }
                }
            }
        }

        private void LimparCampos()
        {
            txtDescricao.Clear();
            txtLocalizacao.Clear();
            txtLatitude.Clear();
            txtLongitude.Clear();
            comboSeveridade.SelectedIndex = 0;
            comboEstado.SelectedIndex = 0;
            comboTipo.SelectedIndex = 0;
            ConfigurarEstadoInicialDosBotoes();
        }
    }
}
