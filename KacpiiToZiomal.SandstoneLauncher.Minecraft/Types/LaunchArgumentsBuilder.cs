using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class LaunchArgumentsBuilder
    {
        public IGamePathBuilder GamePathBuilder;
        public ILibrariesConverter LibrariesConverter;
        public IMinecraftDirectory Minecraft;
        public INativesPathFinder NativesPathFinder;

        public LaunchArgumentsBuilder(IMinecraftDirectory minecraft, IGamePathBuilder gamePathBuilder,
            INativesPathFinder nativesPathFinder, ILibrariesConverter librariesConverter)
        {
            Minecraft = minecraft;
            GamePathBuilder = gamePathBuilder;
            NativesPathFinder = nativesPathFinder;
            LibrariesConverter = librariesConverter;
        }

        public string AccessToken { get; set; } = "";

        public int MaxMemoryMB { get; set; } = 1024;

        public int StartMemoryMB { get; set; } = 256;

        public OS OperatingSystem { get; set; } = OS.WINDOWS;

        public LaunchArguments Create(Dimensions windowDimensions, FullVersion f, string username)
        {
            LaunchArguments a = new LaunchArguments();
            a.AccessToken = AccessToken;
            a.AssetIndex = f.Assets;
            a.AssetsDirectory = Minecraft.GetAssets();
            a.GameDirectory = Minecraft.GetMinecraft();
            a.GameExecutable = GamePathBuilder.GetAbsolutePath(f.Id);
            a.Height = windowDimensions.Height;
            a.Width = windowDimensions.Width;
            a.LauncherBrand = "none";
            a.LauncherVersion = 30;
            a.MainClass = f.MainClass;
            a.NativesPath = NativesPathFinder.GetNativesDirectory(f.Id);
            a.Username = username;
            a.UserType = "mojang";
            a.UUID = "N/A";
            a.VersionType = "Vanilla";
            a.Version = f.Id;
            a.Xmx = MaxMemoryMB;
            a.Xms = StartMemoryMB;
            a.Libraries = LibrariesConverter.ToStringArray(f.Libraries, OperatingSystem);

            return a;
        }
    }
}