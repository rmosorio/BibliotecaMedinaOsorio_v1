using BibliotecaMedinaOsorio_v1.Models;
using System;
using System.Collections.Generic;

namespace BibliotecaMedinaOsorio_v1.Models
{
    public class Funcionario : BaseModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Perfil Perfil { get; set; }
        public IList<Aluguel> Alugueis { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}