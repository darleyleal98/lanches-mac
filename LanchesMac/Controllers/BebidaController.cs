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

        public IActionResult Index()
        {
            var bebidasListViewModels = new BebidaListViewModel();
            bebidasListViewModels.Bebidas = bebidasListViewModels.Bebidas;
            bebidasListViewModels.CategoriaAtual = "Bebidas";

            return View(bebidasListViewModels);
        }
    }
}
