using Backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Data
{
    public class ProdutoContext : DbContext
    {

        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options)
        {
        }

        public DbSet<ProdutoModel> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProdutoModel>()
                .Property(p => p.Nome)
                    .HasMaxLength(40);

            modelBuilder.Entity<ProdutoModel>()
                .Property(p => p.Preco)
                    .HasPrecision(8, 2);


            modelBuilder.Entity<ProdutoModel>()
                .HasData(
                    new ProdutoModel { Id = 1, Nome = "Produto A", Preco = 9.00M },
                    new ProdutoModel { Id = 2, Nome = "Produto B", Preco = 5.00M },
                    new ProdutoModel { Id = 3, Nome = "Produto C", Preco = 15.00M },
                    new ProdutoModel { Id = 4, Nome = "Produto D", Preco = 16.00M },
                    new ProdutoModel { Id = 5, Nome = "Produto E", Preco = 17.00M },
                    new ProdutoModel { Id = 6, Nome = "Produto F", Preco = 18.00M },
                    new ProdutoModel { Id = 7, Nome = "Produto G", Preco = 19.00M },
                    new ProdutoModel { Id = 8, Nome = "Produto H", Preco = 20.00M },
                    new ProdutoModel { Id = 9, Nome = "Produto I", Preco = 21.00M },
                    new ProdutoModel { Id = 10, Nome = "Produto J", Preco = 22.00M },
                    new ProdutoModel { Id = 11, Nome = "Produto K", Preco = 23.00M },
                    new ProdutoModel { Id = 12, Nome = "Produto L", Preco = 24.00M },
                    new ProdutoModel { Id = 13, Nome = "Produto M", Preco = 25.00M }
                    );
        }
    }
}
