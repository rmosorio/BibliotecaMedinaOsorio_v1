using BibliotecaMedinaOsorio_v1.Models;
using System;
using System.Collections.Generic;

namespace BibliotecaMedinaOsorio_v1.Models
{
    public class ItemAluguel : BaseModel
    {

        public int Id_Aluguel { get; set; }
        public int Id_Livro { get; set; }
        public Aluguel Aluguel { get; set; }        
        public Livro Livro { get; set; }
        public DateTime DataDevolucao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}