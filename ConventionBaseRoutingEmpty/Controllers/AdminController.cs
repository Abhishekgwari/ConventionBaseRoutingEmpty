using Microsoft.AspNetCore.Mvc;

namespace ConventionBaseRoutingEmpty.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
