using Grandion_Fast_Food.Models;

namespace Grandion_Fast_Food.Repositores
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
        Lanche GetLancheById(int lancheId);
      
    }
}
