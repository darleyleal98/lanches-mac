using LanchesMac.Repositories.Interfaces;
using LanchesMac.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class SobremesaController : Controller
    {
        private readonly ISobremesaRepository _sobremesaRepository;

        public SobremesaController(ISobremesaRepository sobremesaRepository)
        {
            _sobremesaRepository = sobremesaRepository;
        }

        public IActionResult List()
        {
            var sobremesaListViewModels = new SobremesaListViewModel();
            sobremesaListViewModels.Sobremesas = _sobremesaRepository.Sobremesas;
            sobremesaListViewModels.CategoriaAtual = "Sobremesas";

            return View(sobremesaListViewModels);
        }
    }
}