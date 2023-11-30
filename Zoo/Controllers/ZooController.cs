using Microsoft.AspNetCore.Mvc;

namespace Zoo.Controllers
{
    public class ZooController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
