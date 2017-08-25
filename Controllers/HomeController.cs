using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mrandmuse.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("Error")]
        public IActionResult Error()
        {
            return View();
        }

		[Route("Privacy")]
		public IActionResult Privacy()
		{
			return View();
		}

		[Route("Refunds")]
		public IActionResult Refunds()
		{
			return View();
		}

		[Route("Terms")]
		public IActionResult Terms()
		{
			return View();
		}
    }
}
