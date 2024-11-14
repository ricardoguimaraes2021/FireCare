using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace FireCare.Models
{
    public class Ocorrencia : EntidadeBase
    {
        public string Descricao { get; set; }
        public string Localizacao { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public DateTime DataHora { get; set; }
        public SeveridadeOcorrencia Severidade { get; set; }
        public EstadoOcorrencia Estado { get; set; }
        public TipodeOcorrencia Tipo { get; set; }

        public List<Profissional> ProfissionaisAlocados { get; set; } = new List<Profissional>();
        public List<Equipamento> EquipamentosAlocados { get; set; } = new List<Equipamento>();

        public Ocorrencia()
        {
            ProfissionaisAlocados = new List<Profissional>();
            EquipamentosAlocados = new List<Equipamento>();
        }
    }

    public enum SeveridadeOcorrencia
    {
        Baixa,
        Media,
        Alta
    }

    public enum EstadoOcorrencia
    {
        Ativo,
        Resolvido,
        EmAndamento
    }

    public enum TipodeOcorrencia
    {
        Incendio,
        Resgate,
        Acidente,
        Inundacao,
        Derrocada,
        Outro
    }
}

