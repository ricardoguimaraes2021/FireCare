using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireCare.Models
{
    public class CategoriaEquipamento : EntidadeBase
    {
        public string Nome { get; set; }

        public CategoriaEquipamento() { }

        public CategoriaEquipamento(string nome)
        {
            Nome = nome;
        }
    }
}
