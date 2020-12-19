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

        public ConsultaController(IClienteRepository clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }

        public async Task<IActionResult> Cliente()
        {
            return View(await clienteRepository.GetClientes());
        }
    }
}
