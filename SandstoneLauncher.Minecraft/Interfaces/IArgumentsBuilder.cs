using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IArgumentsBuilder
    {
        LaunchArguments CreateFromUsername(string username, FullVersion fullVersion);

        LaunchArguments CreateFromResponse(MojangLoginResponse response, FullVersion fullVersion);
    }
}