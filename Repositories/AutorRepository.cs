using BibliotecaMedinaOsorio_v1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaMedinaOsorio_v1.Repositories
{
    public interface IAutorRepository
    {
        public void CadastroAutor(Autor autor);
        public Task<IList<Autor>> GetAutores();
        public Autor GetAutor(int id);
    }

    public class AutorRepository : BaseRepository<Autor>, IAutorRepository
    {
        public AutorRepository(ApplicationContext contexto) : base(contexto)
        {            
        }

        public void CadastroAutor(Autor autor)
        {
            
            autor.DataAtualizacao = DateTime.Now;
            

            if (autor.Id == 0)
            {
                autor.DataCadastro = DateTime.Now;
                dbSet.Add(autor);
            }
            else
            {
                dbSet.Update(autor);
            }

            contexto.SaveChanges();
        }

        public Autor GetAutor(int id)
        {
            return dbSet.Where(c => c.Id == id).FirstOrDefault();
        }

        public async Task<IList<Autor>> GetAutores()
        {
            return await dbSet.ToListAsync();
        }
    }

}
