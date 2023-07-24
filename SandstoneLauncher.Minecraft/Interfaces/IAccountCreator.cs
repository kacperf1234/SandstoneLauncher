using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface IAccountCreator
    {
        Account Create(MojangLoginResponse loginResponse);

        Account Create(string username);
    }
}