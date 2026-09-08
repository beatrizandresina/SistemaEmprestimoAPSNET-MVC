using Microsoft.AspNetCore.Mvc;

namespace EmprestimoLivros.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
