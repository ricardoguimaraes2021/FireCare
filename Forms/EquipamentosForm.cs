using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FireCare.Models;
using FireCare.Services;

namespace FireCare
{
    public partial class EquipamentosForm : Form
    {
        private readonly EquipamentoServico equipamentoService = new EquipamentoServico();

        public EquipamentosForm()
        {
            InitializeComponent();
            this.Load += EquipamentosForm_Load;
        }

        private void EquipamentosForm_Load(object sender, EventArgs e)
        {
            CarregarCategorias();
            CarregarEstados();
            CarregarOrigens();
            CarregarEquipamentosNaListView();
            ConfigurarEstadoInicialDosBotoes();
        }

        private void CarregarCategorias()
        {
            comboCategoria.Items.Clear();
            foreach (var categoria in Enum.GetValues(typeof(CategoriaEquipamentoTipo)))
            {
                comboCategoria.Items.Add(categoria.ToString());
            }
            comboCategoria.SelectedIndex = 0;
        }

        private void CarregarEstados()
        {
            comboEstado.Items.Clear();
            comboEstado.Items.AddRange(Enum.GetNames(typeof(Estado)));
            comboEstado.SelectedIndex = 0;
        }

        private void CarregarOrigens()
        {
            comboOrigem.Items.Clear();
            comboOrigem.Items.Add("Base");
            comboOrigem.Items.Add("Doacao");
            comboOrigem.SelectedIndex = 0;
        }

        private void CarregarEquipamentosNaListView()
        {
            listViewEquipamentos.Items.Clear();
            List<Equipamento> equipamentos = equipamentoService.ObterTodosEquipamentos();

            foreach (var equipamento in equipamentos)
            {
                ListViewItem item = new ListViewItem(equipamento.Nome);
                item.SubItems.Add(equipamento.Categoria);
                item.SubItems.Add(equipamento.Quantidade.ToString());
                item.SubItems.Add(equipamento.Origem);
                item.SubItems.Add(equipamento.Estado.ToString());
                item.Tag = equipamento.Id; // Associa o ID do equipamento ao item
                listViewEquipamentos.Items.Add(item);
            }
        }


        private void ConfigurarEstadoInicialDosBotoes()
        {
            btnAdicionarEquipamento.Enabled = true;
            btnEditarEquipamento.Enabled = false;
            btnExcluirEquipamento.Enabled = false;
        }

        private void btnAdicionarEquipamento_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQuantidade.Text, out int quantidade))
            {
                MessageBox.Show("Por favor, insira uma quantidade válida.");
                return;
            }

            var equipamento = new Equipamento
            {
                Nome = txtNomeEquipamento.Text,
                Categoria = comboCategoria.SelectedItem.ToString(),
                Quantidade = quantidade,
                Origem = comboOrigem.SelectedItem.ToString(),
                Estado = (Estado)Enum.Parse(typeof(Estado), comboEstado.SelectedItem.ToString())
            };

            if (equipamentoService.AdicionarEquipamento(equipamento))
            {
                MessageBox.Show("Equipamento adicionado com sucesso!");
                LimparCampos();
                CarregarEquipamentosNaListView();
            }
            else
            {
                MessageBox.Show("Erro ao adicionar equipamento.");
            }
        }

        private void btnExcluirEquipamento_Click(object sender, EventArgs e)
        {
            if (listViewEquipamentos.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewEquipamentos.SelectedItems[0];
                int equipamentoId = (int)item.Tag;

                var confirmResult = MessageBox.Show("Tem certeza de que deseja excluir este equipamento?", "Confirmação", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    if (equipamentoService.EliminarEquipamento(equipamentoId))
                    {
                        MessageBox.Show("Equipamento excluído com sucesso!");
                        LimparCampos();
                        CarregarEquipamentosNaListView();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir equipamento.");
                    }
                }
            }
        }

        private void LimparCampos()
        {
            txtNomeEquipamento.Clear();
            comboCategoria.SelectedIndex = 0;
            txtQuantidade.Clear();
            comboOrigem.SelectedIndex = 0;
            comboEstado.SelectedIndex = 0;
            ConfigurarEstadoInicialDosBotoes();
        }


        private void listViewEquipamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se um item foi selecionado
            if (listViewEquipamentos.SelectedItems.Count > 0)
            {
                // Obtém o item selecionado
                ListViewItem item = listViewEquipamentos.SelectedItems[0];
                int equipamentoId = (int)item.Tag; // ID do equipamento armazenado no Tag do ListViewItem

                // Busca o equipamento pelo ID
                Equipamento equipamento = equipamentoService.ObterEquipamentoPorId(equipamentoId);

                if (equipamento != null)
                {
                    // Preenche os campos do formulário com os dados do equipamento
                    txtNomeEquipamento.Text = equipamento.Nome;
                    comboCategoria.SelectedItem = equipamento.Categoria; // Verifique se "Categoria" está sendo carregada corretamente
                    txtQuantidade.Text = equipamento.Quantidade.ToString();
                    comboOrigem.SelectedItem = equipamento.Origem;
                    comboEstado.SelectedItem = equipamento.Estado.ToString();

                    // Ativa os botões de Atualizar e Excluir, e desativa o botão de Adicionar
                    btnAdicionarEquipamento.Enabled = false;
                    btnEditarEquipamento.Enabled = true;
                    btnExcluirEquipamento.Enabled = true;
                }
            }
            else
            {
                // Se nenhum item está selecionado, configura o estado inicial dos botões
                ConfigurarEstadoInicialDosBotoes();
            }
        }

        private void btnEditarEquipamento_Click(object sender, EventArgs e)
        {
            if (listViewEquipamentos.SelectedItems.Count > 0 && int.TryParse(txtQuantidade.Text, out int quantidade))
            {
                ListViewItem item = listViewEquipamentos.SelectedItems[0];
                int equipamentoId = (int)item.Tag; // ID do equipamento que foi selecionado

                // Cria um objeto Equipamento com os novos valores
                var equipamento = new Equipamento
                {
                    Id = equipamentoId,
                    Nome = txtNomeEquipamento.Text,
                    Categoria = comboCategoria.SelectedItem.ToString(),
                    Quantidade = quantidade,
                    Origem = comboOrigem.SelectedItem.ToString(),
                    Estado = (Estado)Enum.Parse(typeof(Estado), comboEstado.SelectedItem.ToString())
                };

                // Chama o serviço para atualizar o equipamento no banco de dados
                if (equipamentoService.AtualizarEquipamento(equipamento))
                {
                    MessageBox.Show("Equipamento atualizado com sucesso!");

                    // Recarrega a lista para refletir a atualização
                    CarregarEquipamentosNaListView();
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar equipamento.");
                }
            }
            else
            {
                MessageBox.Show("Selecione um equipamento e insira uma quantidade válida.");
            }
        }

    }
}
