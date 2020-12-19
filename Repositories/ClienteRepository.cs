using BibliotecaMedinaOsorio_v1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaMedinaOsorio_v1.Repositories
{
    public interface IClienteRepository
    {
        public void CadastroCliente(Cliente cliente);
        public Task<IList<Cliente>> GetClientes();

        public Cliente GetCliente(int id);
    }

    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ApplicationContext contexto) : base(contexto)
        {            
        }

        public void CadastroCliente(Cliente cliente)
        {
            
            cliente.DataAtualizacao = DateTime.Now;
            

            if (cliente.Id == 0)
            {
                cliente.DataCadastro = DateTime.Now;
                dbSet.Add(cliente);
            }
            else
            {
                dbSet.Update(cliente);
            }

            contexto.SaveChanges();
        }

        public Cliente GetCliente(int id)
        {
            return dbSet.Where(c => c.Id == id).FirstOrDefault();
        }

        public async Task<IList<Cliente>> GetClientes()
        {
            return await dbSet.ToListAsync();
        }
    }

}
