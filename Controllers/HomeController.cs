using Microsoft.AspNetCore.Mvc;

namespace Business.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
