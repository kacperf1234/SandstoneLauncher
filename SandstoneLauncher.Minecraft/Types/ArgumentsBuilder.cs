using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class ArgumentsBuilder : IArgumentsBuilder
    {
        public IGamePathBuilder GamePathBuilder;
        public ILibrariesConverter LibrariesConverter;
        public int MaxMemoryMb = 1024;

        public IMinecraftDirectory Minecraft;
        public INativesPathFinder NativesPathFinder;
        public OS OperatingSystem = OS.WINDOWS;
        public int StartMemoryMb = 256;
        public Dimensions WindowDimensions = new Dimensions(854, 480);

        public ArgumentsBuilder(IMinecraftDirectory minecraft, ILibrariesConverter librariesConverter,
            INativesPathFinder nativesPathFinder, IGamePathBuilder gamePathBuilder)
        {
            Minecraft = minecraft;
            LibrariesConverter = librariesConverter;
            NativesPathFinder = nativesPathFinder;
            GamePathBuilder = gamePathBuilder;
        }

        public LaunchArguments CreateFromUsername(string username, FullVersion fullVersion)
        {
            LaunchArguments a = new LaunchArguments();
            a.AccessToken = null;
            a.AssetIndex = fullVersion.Assets;
            a.AssetsDirectory = Minecraft.GetAssets();
            a.GameDirectory = Minecraft.GetMinecraft();
            a.GameExecutable = GamePathBuilder.GetAbsolutePath(fullVersion.Id);
            a.Height = WindowDimensions.Height;
            a.Width = WindowDimensions.Width;
            a.LauncherBrand = "none";
            a.LauncherVersion = 30;
            a.MainClass = fullVersion.MainClass;
            a.NativesPath = NativesPathFinder.GetNativesDirectory(fullVersion.Id);
            a.Username = username;
            a.UserType = "mojang";
            a.UUID = "N/A";
            a.VersionType = "Vanilla";
            a.Version = fullVersion.Id;
            a.Xmx = MaxMemoryMb;
            a.Xms = StartMemoryMb;
            a.Libraries = LibrariesConverter.ToStringArray(fullVersion.Libraries, OperatingSystem);

            return a;
        }

        public LaunchArguments CreateFromResponse(MojangLoginResponse response, FullVersion fullVersion)
        {
            LaunchArguments a = new LaunchArguments();
            a.AccessToken = response.AccessToken;
            a.AssetIndex = fullVersion.Assets;
            a.AssetsDirectory = Minecraft.GetAssets();
            a.GameDirectory = Minecraft.GetMinecraft();
            a.GameExecutable = GamePathBuilder.GetAbsolutePath(fullVersion.Id);
            a.Height = WindowDimensions.Height;
            a.Width = WindowDimensions.Width;
            a.LauncherBrand = "none";
            a.LauncherVersion = 30;
            a.MainClass = fullVersion.MainClass;
            a.NativesPath = NativesPathFinder.GetNativesDirectory(fullVersion.Id);
            a.Username = response.SelectedProfile.Name;
            a.UserType = "mojang";
            a.UUID = response.SelectedProfile.Id;
            a.VersionType = "Vanilla";
            a.Version = fullVersion.Id;
            a.Xmx = MaxMemoryMb;
            a.Xms = StartMemoryMb;
            a.Libraries = LibrariesConverter.ToStringArray(fullVersion.Libraries, OperatingSystem);

            return a;
        }
    }
}