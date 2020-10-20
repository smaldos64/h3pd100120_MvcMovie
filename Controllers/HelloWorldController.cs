using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // LTPE uncommented code below.
        //public string Index()
        //{
        //    return "This is my default action...";
        //}

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        // LTPE uncommented code below.
        //public string Welcome(string name, int ID = 1)
        //{
        //    return (HtmlEncoder.Default.Encode($"Hello {name}, ID is : {ID}"));
        //}

        // LTPE uncommented code below.
        //public string Welcome(string name, int numTimes = 1)
        //{
        //    return (HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is : {numTimes}"));
        //}

        // LTPE uncommented code below.
        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}

        // LTPE uncommented code below.
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}