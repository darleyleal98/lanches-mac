using LanchesMac.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class SobremesaController : Controller
    {
        public IActionResult Index()
        {
            var sobremesaListViewModels = new SobremesaListViewModel();
            sobremesaListViewModels.Sobremesas = sobremesaListViewModels.Sobremesas;
            sobremesaListViewModels.CategoriaAtual = "Categoria Atual";

            return View(sobremesaListViewModels);
        }
    }
}
