using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class BebidasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
