using LanchesMac.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set; }
        public DbSet<Sobremesa> Sobremesas { get; set; }
        public DbSet<Bebida> Bebidas { get; set; }
        public DbSet<CarrinhoCompraItem> CarrinhocomprasItem { get; set; }
    }
}