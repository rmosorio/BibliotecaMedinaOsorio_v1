using BibliotecaMedinaOsorio_v1.Models;
using BibliotecaMedinaOsorio_v1.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaMedinaOsorio_v1.Controllers
{
    public class CadastroController : Controller
    {
        private readonly IClienteRepository clienteRepository;
        private readonly IFuncionarioRepository funcionarioRepository;
        private readonly IAutorRepository autorRepository;
        private readonly ILivroRepository livroRepository;

        public CadastroController(IClienteRepository clienteRepository, IFuncionarioRepository funcionarioRepository, IAutorRepository autorRepository, ILivroRepository livroRepository)
        {
            this.clienteRepository = clienteRepository;
            this.funcionarioRepository = funcionarioRepository;
            this.autorRepository = autorRepository;
            this.livroRepository = livroRepository;
        }

        public IActionResult Cliente(int id)
        {
            if (id == 0)
            {
                return View();
            }

            Cliente cliente = clienteRepository.GetCliente(id);

            return View(cliente);
        }

        [HttpPost]
        public IActionResult CadastroCliente(Cliente cliente)
        {

            clienteRepository.CadastroCliente(cliente);

            return RedirectToAction("Cliente");
        }

        public IActionResult Funcionario(int id)
        {
            if (id == 0)
            {
                return View();
            }

            Funcionario funcionario = funcionarioRepository.GetFuncionario(id);

            return View(funcionario);
        }

        [HttpPost]
        public IActionResult CadastroFuncionario(Funcionario funcionario)
        {

            funcionarioRepository.CadastroFuncionario(funcionario);

            return RedirectToAction("Funcionario");
        }

        public IActionResult Autor(int id)
        {
            if (id == 0)
            {
                return View();
            }

            Autor autor = autorRepository.GetAutor(id);

            return View(autor);
        }

        [HttpPost]
        public IActionResult CadastroAutor(Autor autor)
        {

            autorRepository.CadastroAutor(autor);

            return RedirectToAction("Autor");
        }

        public IActionResult Livro(int id)
        {
            if (id == 0)
            {
                return View();
            }

            Livro livro = livroRepository.GetLivro(id);

            return View(livro);
        }

        [HttpPost]
        public IActionResult CadastroLivro(Livro livro)
        {

            livroRepository.CadastroLivro(livro);

            return RedirectToAction("Livro");
        }

    }
}
