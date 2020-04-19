using System.Text;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class LaunchCommandBuilder : ILaunchCommandBuilder
    {
        private string BuildResult;
        public ILibrariesConverter Converter;
        public IMemoryStringBuilder MemoryBuilder;

        public LaunchCommandBuilder(ILibrariesConverter converter, IMemoryStringBuilder memoryBuilder)
        {
            Converter = converter;
            MemoryBuilder = memoryBuilder;
        }

        public void Build(LaunchArguments arguments)
        {
            StringBuilder b = new StringBuilder();
            b.Append(" ");
            b.Append(MemoryBuilder.Build(arguments.GetXmx(), arguments.GetXms()));

            b.Append(" ");
            b.Append($"-Dorg.lwjgl.librarypath={arguments.GetNativesPath()}");
            b.Append($" -Djava.library.path={arguments.GetNativesPath()} ");
            b.Append($"-Dminecraft.launcher.brand={arguments.GetLauncherBrand()} ");
            b.Append($"-Dminecraft.launcher.version={arguments.GetLauncherVersion()}");
            b.Append("");
            b.Append("-XX:+CreateMinidumpOnCrash");
            b.Append(" -cp ");
            b.Append(Converter.Convert(arguments.GetLibraries()));
            b.Append(arguments.GetGameExecutable());
            b.Append(" ");
            b.Append(arguments.GetMainClass());
            b.Append($" --width {arguments.GetWidth()} ");
            b.Append($"--height {arguments.GetHeight()} ");
            b.Append($"--username {arguments.GetUsername()} ");
            b.Append($"--version {arguments.GetVersion()} ");
            b.Append($"--gameDir {arguments.GetGameDirectory()} ");
            b.Append($"--assetsDir {arguments.GetAsssetDirectory()} ");
            b.Append($"--assetIndex {arguments.GetAssetIndex()} ");
            b.Append($"--accessToken {arguments.GetAccessToken()} ");
            b.Append($"--versionType {arguments.GetVersionType()} ");
            b.Append($"--userType {arguments.GetUserType()} ");
            b.Append($"--uuid {arguments.GetUUID()} ");

            BuildResult = b.ToString();
        }

        public string GetCommand()
        {
            return BuildResult;
        }

        public string GetCommand(LaunchArguments arguments)
        {
            string javaargs =
                $"{MemoryBuilder.Build(arguments.Xmx, arguments.Xms)} -Dorg.lwjgl.librarypath={arguments.NativesPath} -Djava.library.path={arguments.NativesPath} -Dminecraft.launcher.brand={arguments.LauncherBrand} -Dminecraft.launcher.version={arguments.LauncherVersion}";
            string xx = "-XX:+CreateMinidumpOnCrash";
            string libraries = $"-cp {Converter.Convert(arguments.Libraries)}{arguments.GameExecutable}";
            string mainclass = arguments.MainClass;
            string dimensions = $"--width {arguments.Width} --height {arguments.Height}";
            string gameargs =
                $"--username {arguments.Username} --version {arguments.Version} --gameDir {arguments.GameDirectory} --assetsDir {arguments.AssetsDirectory} --assetIndex {arguments.AssetIndex} --uuid {arguments.UUID} --accessToken {arguments.AccessToken} --versionType {arguments.VersionType} --userType {arguments.UserType}";

            return $"{javaargs} {xx} {libraries} {mainclass} {dimensions} {gameargs}";
        }
    }
}