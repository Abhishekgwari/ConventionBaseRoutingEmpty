using Microsoft.AspNetCore.Mvc;

namespace ConventionBaseRoutingEmpty.Controllers
{
    // [Route("Home")] //  if we write here controller name here so 
    //   in below we dont have to write controller name
    //  we have to write action only
    //  
    //  [Route("Controller")] // tokens
 [Route("[Controller]/[action]")]// tokens so we dont have to reapet
    public class HomeController : Controller
    {
        [Route("")]          //  Empty route
        [Route("Home")]
        [Route("Home/Index")]
        //      [Route("Index")]   // index action methods 


        // [Route("Action")]  // tokens 
        public IActionResult Index()
        {
            return View();
        }
        [Route("Home/About")]
        // [Route("Action")]
        public IActionResult About()
        {
            return View();
        }
        [Route("Home/Details/{id?}")]  // to make id optional use ?
        public int Details(int? id)
        {
            return id ?? 1;
        }
    }
}
