using Grandion_Fast_Food.Models;
using Microsoft.EntityFrameworkCore;

namespace Grandion_Fast_Food.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>option) : base(option)
        {

        }
        
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set; }
        public DbSet<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }

    }
}
