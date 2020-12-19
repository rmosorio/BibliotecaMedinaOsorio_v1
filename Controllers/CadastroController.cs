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

        public CadastroController(IClienteRepository clienteRepository)
        {
            this.clienteRepository = clienteRepository;
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

    }
}
