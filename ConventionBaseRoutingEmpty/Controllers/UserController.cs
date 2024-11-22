using Microsoft.AspNetCore.Mvc;

namespace ConventionBaseRoutingEmpty.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
