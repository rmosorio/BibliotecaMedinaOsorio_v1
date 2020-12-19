using BibliotecaMedinaOsorio_v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaMedinaOsorio_v1.Models
{
    public class Aluguel : BaseModel
    {
        public int Id { get; set; }
        public Funcionario Funcionario { get; set; }
        public Cliente Cliente { get; set; }
        public IList<ItemAluguel> ItemAlugueis { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
