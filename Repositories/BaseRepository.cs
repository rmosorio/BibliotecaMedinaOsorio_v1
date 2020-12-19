﻿using BibliotecaMedinaOsorio_v1.Models;
using Microsoft.EntityFrameworkCore;


namespace BibliotecaMedinaOsorio_v1.Repositories
{
    public abstract class BaseRepository<T> where T : BaseModel
    {
        protected readonly ApplicationContext contexto;
        protected readonly DbSet<T> dbSet;

        public BaseRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
            dbSet = contexto.Set<T>();
        }
    }
}
