using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using KacpiiToZiomal.SandstoneLauncher.Accounts.Models;
using KacpiiToZiomal.SandstoneLauncher.Accounts.Types;
using KacpiiToZiomal.SandstoneLauncher.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Commons.Types;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Types;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace KacpiiToZiomal.SandstoneLauncher.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            AccountGenerator generator = new AccountGenerator(new CredentialsOnlineValidator(), new MojangCredentialsBuilder(), new MojangService(new MojangAuthentication(new NetworkClient(), new JsonDeserializer<MojangLoginResponse>(), new CredentialsJsonBuilder(), new ResponseValidator(), null)), new AccountCreator());
            Account acc = generator.GenerateAccount(new Credentials()
            {
                Username = "kacpisiek",
                IsOnline = false
            });

            return Json(acc);
        }
    }
}