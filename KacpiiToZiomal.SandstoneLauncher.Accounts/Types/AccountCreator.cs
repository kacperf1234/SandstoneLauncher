using System;
using KacpiiToZiomal.SandstoneLauncher.Accounts.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Accounts.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Accounts.Types
{
    public class AccountCreator : IAccountCreator
    {
        public Account Create(MojangLoginResponse loginResponse)
        {
            return new Account()
            {
                Username = loginResponse.SelectedProfile.Name,
                Uuid = loginResponse.SelectedProfile.Id,
                AccessToken = loginResponse.AccessToken,
                ClientToken = loginResponse.ClientToken
            };
        }

        public Account Create(string username)
        {
            return new Account()
            {
                Username = username,
                Uuid = "N/A",
                AccessToken = String.Empty,
                ClientToken = String.Empty
            };
        }
    }
}