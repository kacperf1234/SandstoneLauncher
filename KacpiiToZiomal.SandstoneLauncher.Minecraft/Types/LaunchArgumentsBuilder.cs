using KacpiiToZiomal.SandstoneLauncher.Accounts.Models;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Commons.Types;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Commons.Models;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Enums;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Profiles.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class LaunchArgumentsBuilder // TODO remove this and rewrite...
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
            LaunchArguments a = LaunchArguments.Empty();
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

        public LaunchArguments Create(Account account, Profile profile)
        {
            LaunchArguments args = LaunchArguments.Empty();
            args.Height = profile.Height;
            args.Width = profile.Width;
            args.Username = account.Username;
            args.UUID = account.Uuid;
            args.AccessToken = account.AccessToken;
            args.Xmx = profile.Xmx;
            args.Xms = profile.Xms;
            args.AssetIndex = profile.Version.Assets;
            args.AssetsDirectory = Minecraft.GetAssets();
            args.GameDirectory = Minecraft.GetMinecraft();
            args.Version = profile.Version.Id;
            args.VersionType = "Vanilla";
            args.UserType = "mojang";
            args.GameExecutable = GamePathBuilder.GetAbsolutePath(profile.Version.Id);
            args.MainClass = profile.Version.MainClass;
            args.NativesPath = NativesPathFinder.GetNativesDirectory(profile.Version.Id);
            args.Libraries = LibrariesConverter.ToStringArray(profile.Version.Libraries, OperatingSystem);

            return args;
        }
    }
}