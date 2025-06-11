using Grandion_Fast_Food.Models;

namespace Grandion_Fast_Food.Repositores.Interfaces
{
    public interface ICategoriarepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
