using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface ILaunchCommandBuilder
    {
        void Build(LaunchArguments arguments);

        string GetCommand(LaunchArguments arguments);

        string GetCommand();
    }
}