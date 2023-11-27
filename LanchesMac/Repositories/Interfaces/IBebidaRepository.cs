using LanchesMac.Models;

namespace LanchesMac.Repositories.Interfaces
{
    public interface IBebidaRepository
    {
        IEnumerable<Bebida> Bebidas { get; }
        IEnumerable<Bebida> BebidasPreferidas { get; }
        Bebida GetLancheById(int bebidaId);
    }
}
