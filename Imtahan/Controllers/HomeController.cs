using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Imtahan.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}