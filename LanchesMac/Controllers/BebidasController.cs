using LanchesMac.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class BebidasController : Controller
    {
        public IActionResult Index()
        {
            var bebidasListViewModels = new SobremesaListViewModel();
            bebidasListViewModels.Sobremesas = bebidasListViewModels.Sobremesas;
            bebidasListViewModels.CategoriaAtual = "Categoria Atual";

            return View(bebidasListViewModels);
        }
    }
}
