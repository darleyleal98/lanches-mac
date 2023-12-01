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
            var sobremesaListViewModel = new SobremesaListViewModel();
            sobremesaListViewModel.Sobremesas = _sobremesaRepository.Sobremesas;
            sobremesaListViewModel.CategoriaAtual = "Sobremesas";

            return View(sobremesaListViewModel);
        }
    }
}