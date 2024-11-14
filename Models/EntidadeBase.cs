using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireCare.Models
{
    public class EntidadeBase
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime UltimaAtualizacao { get; set; }

        public EntidadeBase()
        {
            DataCriacao = DateTime.Now;
            UltimaAtualizacao = DateTime.Now;
        }
    }
}
