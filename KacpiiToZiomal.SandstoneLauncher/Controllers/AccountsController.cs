using System;
using KacpiiToZiomal.SandstoneLauncher.Accounts.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Accounts.Models;
using KacpiiToZiomal.SandstoneLauncher.Accounts.Types;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Commons.Types;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace KacpiiToZiomal.SandstoneLauncher.Controllers
{
    public class AccountsController : Controller
    {
        public ICredentialsDataProvider CredentialsDataProvider;

        public IActionResult GetAccount()
        {
            return View("Get");
        }

        [HttpPost]
        public IActionResult PostUsername(OfflineCredentials credentials)
        {
            if (ModelState.IsValid)
            {
                return Content(credentials.Username);
            }

            return View("Get");
        }

        [HttpPost]
        public IActionResult PostCredentials(Credentials credentials)
        {
            if (ModelState.IsValid)
            {
                return Json(credentials);
            }

            return View("Get");
        }
    }
}