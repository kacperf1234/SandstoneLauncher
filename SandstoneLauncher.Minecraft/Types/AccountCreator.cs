using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class AccountCreator : IAccountCreator
    {
        public Account Create(MojangLoginResponse loginResponse)
        {
            return new Account
            {
                Username = loginResponse.SelectedProfile.Name,
                Uuid = loginResponse.SelectedProfile.Id,
                AccessToken = loginResponse.AccessToken,
                ClientToken = loginResponse.ClientToken
            };
        }

        public Account Create(string username)
        {
            return new Account
            {
                Username = username,
                Uuid = "N/A",
                AccessToken = string.Empty,
                ClientToken = string.Empty
            };
        }
    }
}