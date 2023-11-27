using LanchesMac.Repositories.Interfaces;
using LanchesMac.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            //var lanches = _lancheRepository.Lanches;
            //var totalLanches = lanches.Count();
            //ViewBag.TotalLanches = totalLanches;

            //ViewData["Titulo"] = $"Todos os lanches: {totalLanches}";
            //ViewData["Data"] = DateTime.Today.ToString("dd/MM/yyyy");

            //return View(lanches);


            var lanchesListViewModels = new LancheListViewModel();
            lanchesListViewModels.Lanches = _lancheRepository.Lanches;
            lanchesListViewModels.CategoriaAtual = "Categoria Atual";

            return View(lanchesListViewModels);
        }
    }
}