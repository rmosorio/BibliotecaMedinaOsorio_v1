using BibliotecaMedinaOsorio_v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaMedinaOsorio_v1.Models
{
    public class Livro : BaseModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Autor Autor { get; set; }
        public Genero Genero { get; set; }        
        public IList<ItemAluguel> ItemAlugueis { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
