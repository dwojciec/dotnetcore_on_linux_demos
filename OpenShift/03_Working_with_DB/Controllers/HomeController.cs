
using Microsoft.AspNetCore.Mvc;



namespace HelloReact.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}