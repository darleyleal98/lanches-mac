using LanchesMac.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class SobremesaController : Controller
    {
        public IActionResult Index()
        {
            var sobremesaListViewModels = new SobremesaListViewModel();
            sobremesaListViewModels.Sobremesas = _lancheRepository.Lanches;
            lanchesListViewModels.CategoriaAtual = "Categoria Atual";

            return View(lanchesListViewModels);
        }
    }
}
