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

            var bebidaListViewModels = new BebidaListViewModel();
            bebidaListViewModels.Bebidas = _bebidaRepository.Bebidas;
            bebidaListViewModels.CategoriaAtual = "Bebidas";

            return View(bebidaListViewModels);
        }
    }
}