using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using FireCare.Models;
using FireCare.Services;

namespace FireCare
{
    public partial class ProfissionaisForm : Form
    {
        private readonly ProfissionalServico profissionalService = new ProfissionalServico();

        public ProfissionaisForm()
        {
            InitializeComponent();
            this.Load += ProfissionaisForm_Load;
            this.Dock = DockStyle.Fill;
        }

        private void ProfissionaisForm_Load(object sender, EventArgs e)
        {
            PreencherProximoId();
            ConfigurarDateTimePicker();
            ConfigurarTxtTelefone();
            DefinirValoresPadraoComboBox();
            CarregarProfissionaisNaListView();
            txtId.Enabled = false;
            ConfigurarEstadoInicialDosBotoes();
        }

        private void ConfigurarEstadoInicialDosBotoes()
        {
            btn_adicionar_profissional.Enabled = true;
            btn_atualizar_profissional.Enabled = false;
            btn_eliminar_profissional.Enabled = false;
        }

        private void PreencherProximoId()
        {
            int proximoId = profissionalService.ObterProximoId();
            txtId.Text = proximoId.ToString();
        }

        private void ConfigurarDateTimePicker()
        {
            dateTimePickerDataNascimento.MaxDate = DateTime.Today.AddDays(-1);
        }

        private void ConfigurarTxtTelefone()
        {
            txtTelefone.MaxLength = 9;
            txtTelefone.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            };
        }

        private void DefinirValoresPadraoComboBox()
        {
            if (comboGenero.Items.Count > 0)
                comboGenero.SelectedIndex = 0;
            if (comboTipoSanguineo.Items.Count > 0)
                comboTipoSanguineo.SelectedIndex = 0;
            if (comboCargo.Items.Count > 0)
                comboCargo.SelectedIndex = 0;
        }

        private void CarregarProfissionaisNaListView()
        {
            listViewProfissionais.Items.Clear();
            List<Profissional> profissionais = profissionalService.ObterTodosProfissionais();

            foreach (var profissional in profissionais)
            {
                ListViewItem item = new ListViewItem(profissional.Id.ToString());
                item.SubItems.Add(profissional.Nome);
                item.SubItems.Add(profissional.Cargo.ToString());
                item.SubItems.Add(profissional.Email);
                item.SubItems.Add(profissional.Disponivel ? "Sim" : "Não");
                listViewProfissionais.Items.Add(item);
            }
        }

        private void listViewProfissionais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProfissionais.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewProfissionais.SelectedItems[0];
                int profissionalId = int.Parse(item.SubItems[0].Text);

                Profissional profissional = profissionalService.ObterProfissionalPorId(profissionalId);

                if (profissional != null)
                {
                    txtId.Text = profissional.Id.ToString();
                    txtNome.Text = profissional.Nome;
                    dateTimePickerDataNascimento.Value = profissional.DataNascimento;
                    comboGenero.SelectedItem = profissional.Genero.ToString();
                    txtEmail.Text = profissional.Email;
                    txtSenha.Text = ""; // Limpa o campo de senha para não mostrar a senha encriptada
                    comboTipoSanguineo.SelectedItem = profissional.TipoSanguineo.ToString();
                    comboCargo.SelectedItem = profissional.Cargo.ToString();
                    txtTelefone.Text = profissional.NumeroTelefone;
                    txtEndereco.Text = profissional.Endereco;

                    btn_adicionar_profissional.Enabled = false;
                    btn_atualizar_profissional.Enabled = true;
                    btn_eliminar_profissional.Enabled = true;
                }
            }
            else
            {
                ConfigurarEstadoInicialDosBotoes();
            }
        }

        private void btn_adicionar_profissional_Click(object sender, EventArgs e)
        {
            try
            {
                string senha = txtSenha.Text;

                if (string.IsNullOrWhiteSpace(senha))
                {
                    MessageBox.Show("Por favor, insira uma senha válida.");
                    return;
                }

                var profissional = new Profissional(
                    txtNome.Text,
                    dateTimePickerDataNascimento.Value,
                    (Genero)Enum.Parse(typeof(Genero), comboGenero.SelectedItem.ToString()),
                    txtEmail.Text,
                    EncriptarSenha(senha), // Encripta a senha fornecida
                    (TipoSanguineo)Enum.Parse(typeof(TipoSanguineo), comboTipoSanguineo.SelectedItem.ToString()),
                    (CargoProfissional)Enum.Parse(typeof(CargoProfissional), comboCargo.SelectedItem.ToString())
                )
                {
                    NumeroTelefone = txtTelefone.Text,
                    Endereco = txtEndereco.Text,
                    Disponivel = true
                };

                if (!profissionalService.ValidarEmail(profissional.Email))
                {
                    MessageBox.Show("Por favor, insira um endereço de email válido.");
                    return;
                }

                if (profissionalService.AdicionarProfissional(profissional))
                {
                    MessageBox.Show("Profissional adicionado com sucesso!");
                    LimparCampos();
                    CarregarProfissionaisNaListView();
                    ConfigurarEstadoInicialDosBotoes();
                }
                else
                {
                    MessageBox.Show("Erro ao adicionar profissional.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar os dados: " + ex.Message);
            }
        }

        private void btn_atualizar_profissional_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int profissionalId))
            {
                string senha = txtSenha.Text;

                if (string.IsNullOrWhiteSpace(senha))
                {
                    MessageBox.Show("Por favor, insira uma senha válida.");
                    return;
                }

                var profissional = new Profissional(
                    txtNome.Text,
                    dateTimePickerDataNascimento.Value,
                    (Genero)Enum.Parse(typeof(Genero), comboGenero.SelectedItem.ToString()),
                    txtEmail.Text,
                    EncriptarSenha(senha), // Encripta a senha fornecida
                    (TipoSanguineo)Enum.Parse(typeof(TipoSanguineo), comboTipoSanguineo.SelectedItem.ToString()),
                    (CargoProfissional)Enum.Parse(typeof(CargoProfissional), comboCargo.SelectedItem.ToString())
                )
                {
                    Id = profissionalId,
                    NumeroTelefone = txtTelefone.Text,
                    Endereco = txtEndereco.Text,
                    Disponivel = true
                };

                if (profissionalService.AtualizarProfissional(profissional))
                {
                    MessageBox.Show("Dados atualizados com sucesso!");
                    CarregarProfissionaisNaListView();
                    LimparCampos();
                    ConfigurarEstadoInicialDosBotoes();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar dados.");
                }
            }
        }

        private void btn_eliminar_profissional_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text, out int profissionalId))
            {
                var confirmResult = MessageBox.Show("Tem certeza de que deseja excluir este profissional?", "Confirmação", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    if (profissionalService.EliminarProfissional(profissionalId))
                    {
                        MessageBox.Show("Profissional excluído com sucesso!");
                        CarregarProfissionaisNaListView();
                        LimparCampos();
                        ConfigurarEstadoInicialDosBotoes();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir profissional.");
                    }
                }
            }
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtTelefone.Clear();
            txtEndereco.Clear();
            comboGenero.SelectedIndex = 0;
            comboTipoSanguineo.SelectedIndex = 0;
            comboCargo.SelectedIndex = 0;
            PreencherProximoId();
        }

        private static string EncriptarSenha(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
