using BibliotecaMedinaOsorio_v1.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaMedinaOsorio_v1.Controllers
{
    public class ConsultaController : Controller
    {

        private readonly IClienteRepository clienteRepository;
        private readonly IFuncionarioRepository funcionarioRepository;
        private readonly IAutorRepository autorRepository;
        private readonly ILivroRepository livroRepository;

        public ConsultaController(IClienteRepository clienteRepository, IFuncionarioRepository funcionarioRepository, IAutorRepository autorRepository, ILivroRepository livroRepository)
        {
            this.clienteRepository = clienteRepository;
            this.funcionarioRepository = funcionarioRepository;
            this.autorRepository = autorRepository;
            this.livroRepository = livroRepository;
        }

        public async Task<IActionResult> Cliente()
        {
            return View(await clienteRepository.GetClientes());
        }

        public async Task<IActionResult> Funcionario()
        {
            return View(await funcionarioRepository.GetFuncionarios());
        }

        public async Task<IActionResult> Autor()
        {
            return View(await autorRepository.GetAutores());
        }

        public async Task<IActionResult> Livro()
        {
            return View(await livroRepository.GetLivros());
        }

    }
}
