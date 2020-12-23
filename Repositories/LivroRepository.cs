using BibliotecaMedinaOsorio_v1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaMedinaOsorio_v1.Repositories
{
    public interface ILivroRepository
    {
        public void CadastroLivro(Livro livro);
        public Task<IList<Livro>> GetLivros();
        public Livro GetLivro(int id);
    }

    public class LivroRepository : BaseRepository<Livro>, ILivroRepository
    {
        public LivroRepository(ApplicationContext contexto) : base(contexto)
        {            
        }

        public void CadastroLivro(Livro livro)
        {
            
            livro.DataAtualizacao = DateTime.Now;
            

            if (livro.Id == 0)
            {
                livro.DataCadastro = DateTime.Now;
                dbSet.Add(livro);
            }
            else
            {
                dbSet.Update(livro);
            }

            contexto.SaveChanges();
        }

        public Livro GetLivro(int id)
        {
            return dbSet.Where(c => c.Id == id).FirstOrDefault();
        }

        public async Task<IList<Livro>> GetLivros()
        {
            return await dbSet.ToListAsync();
        }
    }

}
