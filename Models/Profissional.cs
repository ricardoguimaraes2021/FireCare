using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace FireCare.Models
{
    public class Profissional : EntidadeBase
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; } 
        public Genero Genero { get; set; }  
        public string Email { get; set; }  
        public string Senha { get; set; } 
        public TipoSanguineo TipoSanguineo { get; set; }  
        public CargoProfissional Cargo { get; set; } 
        public bool Disponivel { get; set; } = true; 
        public string NumeroTelefone { get; set; }  
        public string Endereco { get; set; }  

      
        public Profissional(string nome, DateTime dataNascimento, Genero genero, string email, string senha, TipoSanguineo tipoSanguineo, CargoProfissional cargo)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Genero = genero;
            Email = email;
            Senha = senha;
            TipoSanguineo = tipoSanguineo;
            Cargo = cargo;
            Disponivel = true;  
        }
    }

    public enum Genero
    {
        Masculino,
        Feminino
    }

    public enum TipoSanguineo
    {
        APositivo,
        ANegativo,
        BPositivo,
        BNegativo,
        ABPositivo,
        ABNegativo,
        OPositivo,
        ONegativo
    }

    public enum CargoProfissional
    {
        Bombeiro,
        Medico,
        Enfermeiro,
        Tecnico
    }
}

