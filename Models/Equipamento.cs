using System;

namespace FireCare.Models
{
    public class Equipamento : EntidadeBase
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }  // Categoria agora como string para alinhar com o Enum
        public int Quantidade { get; set; }
        public string Origem { get; set; }
        public Estado Estado { get; set; }

        public Equipamento() { }

        public Equipamento(string nome, string categoria, int quantidade, string origem, Estado estado)
        {
            Nome = nome;
            Categoria = categoria;
            Quantidade = quantidade;
            Origem = origem;
            Estado = estado;
        }
    }

    public enum Estado
    {
        Disponivel,
        Indisponivel,
        Manutencao
    }

    public enum CategoriaEquipamentoTipo
    {
        Veiculo,
        Ferramenta,
        Maquina,
        EquipamentoMedico,
        Comunicacao,
        Outro
    }
}
