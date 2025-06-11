using Grandion_Fast_Food.Context;
using Grandion_Fast_Food.Models;
using Grandion_Fast_Food.Repositores.Interfaces;

namespace Grandion_Fast_Food.Repositores
{
    public class CategoriaRepository : ICategoriarepository
    {
        private readonly AppDbContext _Context;

        public CategoriaRepository(AppDbContext context)
        {
            _Context = context;
        }

        public IEnumerable<Categoria> Categorias => _Context.Categorias;
    }
}
