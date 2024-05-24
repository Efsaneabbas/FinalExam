
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExamTest.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

      
    }
}
