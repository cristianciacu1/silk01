using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using silk.Models;

namespace silk.Controllers
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
            var webClient = new WebClient();
            var json = webClient.DownloadString(@"C:\Users\crist\source\repos\cristianciacu1\silk01\silk\silk\wwwroot\lib\json\dataTest2.json");
            var people = JsonConvert.DeserializeObject<People>(json);
            return View(people);
        }

        [HttpGet, Route("Cart")]
        public IActionResult Cart()
        {
            return View();
        }

        [HttpGet, Route("Search")]
        public IActionResult Search()
        {
            return View();
        }

        [HttpGet, Route("itemDetails")]
        public IActionResult ItemDetails()
        {
            return View();
        }
    }
}
