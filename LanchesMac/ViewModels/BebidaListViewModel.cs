using LanchesMac.Models;

namespace LanchesMac.ViewModels
{
    public class BebidaListViewModel
    {
        public IEnumerable<Bebida> Bebidas { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
