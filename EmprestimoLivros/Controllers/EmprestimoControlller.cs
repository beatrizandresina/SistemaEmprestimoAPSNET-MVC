using Microsoft.AspNetCore.Mvc;

namespace EmprestimoLivros.Controllers
{
    public class EmprestimoControlller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
