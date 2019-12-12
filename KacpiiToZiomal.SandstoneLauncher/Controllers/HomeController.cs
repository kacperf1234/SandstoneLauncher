using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KacpiiToZiomal.SandstoneLauncher.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello in aspnetcore");
        }
    }
}