using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireCare.Models
{
    public class Equipamento : EntidadeBase
    {
        public int IdCategoria { get; set; }  // ID da categoria de equipamento
        public Estado Estado { get; set; }  // Estado do equipamento (Disponível, Indisponível, etc.)

        public Equipamento() { }

        public Equipamento(int idCategoria, Estado estado)
        {
            IdCategoria = idCategoria;
            Estado = estado;
        }
    }

    public enum Estado
    {
        Disponivel,
        Indisponivel,
        Manutencao
    }
}
