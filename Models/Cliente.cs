using BibliotecaMedinaOsorio_v1.Models;
using System;
using System.Collections.Generic;


namespace BibliotecaMedinaOsorio_v1.Models
{
    public class Cliente : BaseModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public char Sexo { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public IList<Aluguel> Alugueis { get; set; }        
        public DateTime DataAtualizacao { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}