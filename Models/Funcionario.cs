using BibliotecaMedinaOsorio_v1.Models;
using System;
using System.Collections.Generic;

namespace BibliotecaMedinaOsorio_v1.Models
{
    public class Funcionario : BaseModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public char Sexo { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Email { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public Perfil Perfil { get; set; }
        public IList<Aluguel> Alugueis { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}