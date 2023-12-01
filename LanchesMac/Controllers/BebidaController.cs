using LanchesMac.Repositories.Interfaces;
using LanchesMac.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class BebidaController : Controller
    {
        private readonly IBebidaRepository _bebidaRepository;

        public BebidaController(IBebidaRepository bebidaRepository)
        {
            _bebidaRepository = bebidaRepository;
        }

        public IActionResult List()
        {
            var bebidaListViewModel = new BebidaListViewModel();
            bebidaListViewModel.Bebidas = _bebidaRepository.Bebidas;
            bebidaListViewModel.CategoriaAtual = "Bebidas";

            return View(bebidaListViewModel);
        }
    }
}