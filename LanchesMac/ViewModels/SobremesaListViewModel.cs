using LanchesMac.Models;

namespace LanchesMac.ViewModels
{
    public class SobremesaListViewModel
    {
        public IEnumerable<Sobremesa> Sobremesas { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
