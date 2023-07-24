using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface ILaunchCommandBuilder
    {
        void Build(LaunchArguments arguments);

        string GetCommand(LaunchArguments arguments);

        string GetCommand();
    }
}