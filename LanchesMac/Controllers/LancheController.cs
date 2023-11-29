﻿using LanchesMac.Repositories.Interfaces;
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
            var lanchesListViewModels = new LancheListViewModel();
            lanchesListViewModels.Lanches = _lancheRepository.Lanches;
            lanchesListViewModels.CategoriaAtual = "Lanches";

            return View(lanchesListViewModels);
        }
    }
}