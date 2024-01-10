using ActionResultsTask.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ActionResultsTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //ViewResult

        public IActionResult GetViewResult()
        {
            return View();
        }
        public IActionResult GetViewResult2()
        {
            return View("Second View");
        }


        //PartialViewResult

        public IActionResult GetPartialViewResult()
        {
            return PartialView("Second View");
        }


        //Content Result 
        public IActionResult GetContentResult()
        {
            return Content("Zain Ul Hassan ","text/html");
        }

        //Empty Result
        public IActionResult GetEmptyResult()
        {
            return new EmptyResult();
        }

        //File Result
        public IActionResult GetFileResult()
        {
            return File("~/Files/text.txt", "text/plain");
        }

        public IActionResult GetFileResult2()
        {
            return File(Url.Content("~/Files/text.txt"), "text/plain", "testFile.txt");
        }


        //Json Result 
        public IActionResult GetJsonResult()
        {
            return Json(new { Name = "Zain Ul Hassan", ID = 1 });
        }

        //Redurection Result
        public IActionResult GetRedirectionResult()
        {
            return Redirect("https://www.c-sharpcorner.com/members/zain-ul-hassan2");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}