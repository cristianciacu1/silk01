using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Silk.Data;

namespace Silk.Web.Controllers
{
    public class ShopController : Controller
    {
        private readonly SilkContext context;
        public ShopController(SilkContext silkContext)
        {
            context = silkContext;
        }

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
