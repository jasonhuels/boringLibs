using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("/")]
        public ActionResult MadLib()
        {
            MadLibsVariable myMadLibsVariable = new MadLibsVariable();
            myMadLibsVariable.Noun = "Lina";
            myMadLibsVariable.Verb = "Walk";
            return View(myMadLibsVariable);
        }

        [Route("/form")]
        public ActionResult Form() { return View(); }

        [Route("/madlib")]
        public ActionResult MadLib(string noun, string verb)
        {
            MadLibsVariable myMadLibsVariable = new MadLibsVariable();
            myMadLibsVariable.Verb = verb;
            myMadLibsVariable.Noun= noun;
            return View(myMadLibsVariable);
        }
    }
}
