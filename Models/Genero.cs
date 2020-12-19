using BibliotecaMedinaOsorio_v1.Models;
using System;
using System.Collections.Generic;

namespace BibliotecaMedinaOsorio_v1.Models
{
    public class Genero : BaseModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }        
        public IList<Livro> Livros { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}