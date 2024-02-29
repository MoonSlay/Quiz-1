using Microsoft.AspNetCore.Mvc;
using Quiz_1.Models;
using System.Diagnostics;

namespace Quiz_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}