using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        // Get: /HellowWorld/
        //public string Index()
        //{
        //    return "This is my default action...";
        //}

        public IActionResult Index()
        {
            return View();
        }

        //// 
        //// GET: /HelloWorld/Welcome/ 
        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}

        //// Get: /HelloWorld/Welcome/
        //public string Welcome(string name, int numTimes = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        //}

        //public string Welcome(string name, int ID = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");

        //}

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();

        }














    }
}
