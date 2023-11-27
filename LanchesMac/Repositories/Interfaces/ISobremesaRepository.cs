using LanchesMac.Models;

namespace LanchesMac.Repositories.Interfaces
{
    public interface ISobremesaRepository
    {
        IEnumerable<Sobremesa> Sobremesas { get; }
        IEnumerable<Sobremesa> SobremesasPrferidas { get; }
        Sobremesa GetLancheById(int sobremesaId);
    }
}
