using LanchesMac.Repositories.Interfaces;
using LanchesMac.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class SobremesaController : Controller
    {
        private readonly ISobremesaRepository _sobremesaRepository;

        public SobremesaController(ISobremesaRepository _sobremesaRepository)
        {
            _sobremesaRepository = _sobremesaRepository;
        }

        public IActionResult Index()
        {
            var sobremesaListViewModels = new SobremesaListViewModel();
            sobremesaListViewModels.Sobremesas = sobremesaListViewModels.Sobremesas;
            sobremesaListViewModels.CategoriaAtual = "Sobremesas";

            return View(sobremesaListViewModels);
        }
    }
}
