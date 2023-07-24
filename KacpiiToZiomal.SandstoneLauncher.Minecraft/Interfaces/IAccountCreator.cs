using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IAccountCreator
    {
        Account Create(MojangLoginResponse loginResponse);

        Account Create(string username);
    }
}