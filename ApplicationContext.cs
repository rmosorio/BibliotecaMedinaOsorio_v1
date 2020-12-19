using BibliotecaMedinaOsorio_v1.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaMedinaOsorio_v1
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Livro>().HasKey(t => t.Id);
            modelBuilder.Entity<Livro>().Property(t => t.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Livro>().HasOne(t => t.Autor).WithMany(t => t.Livros).IsRequired();
            modelBuilder.Entity<Livro>().HasOne(t => t.Genero).WithMany(t => t.Livros).IsRequired();
            modelBuilder.Entity<Livro>().HasMany(t => t.ItemAlugueis).WithOne(t => t.Livro);

            modelBuilder.Entity<Autor>().HasKey(t => t.Id);
            modelBuilder.Entity<Autor>().Property(t => t.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Autor>().HasMany(t => t.Livros).WithOne(t => t.Autor);

            modelBuilder.Entity<Genero>().HasKey(t => t.Id);
            modelBuilder.Entity<Genero>().Property(t => t.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Genero>().HasMany(t => t.Livros).WithOne(t => t.Genero);

            modelBuilder.Entity<Aluguel>().HasKey(t => t.Id);
            modelBuilder.Entity<Aluguel>().Property(t => t.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Aluguel>().HasMany(t => t.ItemAlugueis).WithOne(t => t.Aluguel).IsRequired();
            modelBuilder.Entity<Aluguel>().HasOne(t => t.Cliente).WithMany(t => t.Alugueis).IsRequired();
            modelBuilder.Entity<Aluguel>().HasOne(t => t.Funcionario).WithMany(t => t.Alugueis).IsRequired();

            modelBuilder.Entity<ItemAluguel>().HasKey(t => new {t.Id_Aluguel, t.Id_Livro});
            modelBuilder.Entity<ItemAluguel>().HasOne(t => t.Aluguel).WithMany(t => t.ItemAlugueis).IsRequired().HasForeignKey(t => t.Id_Aluguel);
            modelBuilder.Entity<ItemAluguel>().HasOne(t => t.Livro).WithMany(t => t.ItemAlugueis).IsRequired().HasForeignKey(t => t.Id_Livro);

            modelBuilder.Entity<Cliente>().HasKey(t => t.Id);
            modelBuilder.Entity<Cliente>().Property(t => t.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Cliente>().HasMany(t => t.Alugueis).WithOne(t => t.Cliente);

            modelBuilder.Entity<Funcionario>().HasKey(t => t.Id);
            modelBuilder.Entity<Funcionario>().Property(t => t.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Funcionario>().HasMany(t => t.Alugueis).WithOne(t => t.Funcionario);
            modelBuilder.Entity<Funcionario>().HasOne(t => t.Perfil).WithMany(t => t.Funcionarios).IsRequired();

            modelBuilder.Entity<Perfil>().HasKey(t => t.Id);
            modelBuilder.Entity<Perfil>().Property(t => t.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Perfil>().HasMany(t => t.Funcionarios).WithOne(t => t.Perfil);
        }
    }
}
