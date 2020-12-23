using BibliotecaMedinaOsorio_v1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaMedinaOsorio_v1.Repositories
{
    public interface IFuncionarioRepository
    {
        public void CadastroFuncionario(Funcionario funcionario);
        public Task<IList<Funcionario>> GetFuncionarios();
        public Funcionario GetFuncionario(int id);
    }

    public class FuncionarioRepository : BaseRepository<Funcionario>, IFuncionarioRepository
    {
        public FuncionarioRepository(ApplicationContext contexto) : base(contexto)
        {            
        }

        public void CadastroFuncionario(Funcionario funcionario)
        {
            
            funcionario.DataAtualizacao = DateTime.Now;
            

            if (funcionario.Id == 0)
            {
                funcionario.DataCadastro = DateTime.Now;
                dbSet.Add(funcionario);
            }
            else
            {
                dbSet.Update(funcionario);
            }

            contexto.SaveChanges();
        }

        public Funcionario GetFuncionario(int id)
        {
            return dbSet.Where(c => c.Id == id).FirstOrDefault();
        }

        public async Task<IList<Funcionario>> GetFuncionarios()
        {
            return await dbSet.ToListAsync();
        }
    }

}
