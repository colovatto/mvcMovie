using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace mvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()        
        {
            return View();           
        }

        public IActionResult Welcome(string nome = "Carlos", int numTimes = 1)
        {
            ViewData["Message"] = nome;
            ViewData["NumTimes"] = 10;
           
            return View();
        }
    }
}
