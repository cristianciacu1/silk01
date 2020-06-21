using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Silk.Web.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Browse");
        }

        [HttpGet, Route("Browse")]
        public IActionResult Browse()
        {
            return View();
        }

        [HttpGet, Route("Cart")]
        public IActionResult Cart()
        {
            return View();
        }
    }
}
