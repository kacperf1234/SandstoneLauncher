using KacpiiToZiomal.SandstoneLauncher.Accounts.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Authorization.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Accounts.Interfaces
{
    public interface IAccountCreator
    {
        Account Create(MojangLoginResponse loginResponse);

        Account Create(string username);
    }
}