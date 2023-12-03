using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;
using LanchesMac.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(ILancheRepository lancheRepository, CarrinhoCompra carrinhoCompra)
        {
            _lancheRepository = lancheRepository;
            _carrinhoCompra = carrinhoCompra;
        }
        public IActionResult Index()
        {
            var itens = _carrinhoCompra.GetCarrinhoCompraItens();

            _carrinhoCompra.CarrinhoCompraItens = itens;

            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
            };
            return View(carrinhoCompraVM);
        }

        /// <summary>
        /// 
        /// RedirectToActionResult:
        /// 
        /// 302 - Found
        /// 301 - Moved Permanently
        /// 307 - Temporary Redirect
        /// 308 - Permanent Redirect
        /// 
        /// </summary>

        public RedirectToActionResult AdicionarItemDoCarrinhoCompra(int lancheId)
        {
            
            var lancheSeleciondo = _lancheRepository.Lanches.FirstOrDefault(p =>  p.LancheId == lancheId);

            if (lancheSeleciondo != null)
            {
                _carrinhoCompra.AdicionarAoCarrinho(lancheSeleciondo);
            }

            return RedirectToAction("Index");   
        }
        public IActionResult RemoverItemDoCarrinhoCompra(int lancheId)
        {

            var lancheSeleciondo = _lancheRepository.Lanches.FirstOrDefault(p => p.LancheId == lancheId);

            if (lancheSeleciondo != null)
            {
                _carrinhoCompra.RemoveDoCarrinho(lancheSeleciondo);
            }

            return RedirectToAction("Index");
        }
    }
}