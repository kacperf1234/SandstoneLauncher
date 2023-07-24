namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Models
{
    public class LaunchArguments
    {
        public string AccessToken;
        public string AssetIndex;
        public string AssetsDirectory;
        public string GameDirectory;

        public string GameExecutable;
        public int Height;
        public string LauncherBrand;
        public int LauncherVersion;

        public string[] Libraries;
        public string MainClass;
        public string NativesPath;
        public string Username;
        public string UserType;
        public string UUID;
        public string Version;
        public string VersionType;
        public int Width;
        public int Xms;
        public int Xmx;
        public string XX;

        public LaunchArguments()
        {
        }

        public LaunchArguments(int xmx,
            int xms,
            int width,
            int height,
            int launcherVersion,
            string gameExecutable,
            string versionType,
            string uUID,
            string gameDirectory,
            string assetsDirectory,
            string username,
            string mainClass,
            string assetIndex,
            string version,
            string accessToken,
            string xX,
            string userType,
            string nativesPath,
            string launcherBrand,
            string[] libraries)
        {
            Xmx = xmx;
            Xms = xms;
            Width = width;
            Height = height;
            LauncherVersion = launcherVersion;
            GameExecutable = gameExecutable;
            VersionType = versionType;
            UUID = uUID;
            GameDirectory = gameDirectory;
            AssetsDirectory = assetsDirectory;
            Username = username;
            MainClass = mainClass;
            AssetIndex = assetIndex;
            Version = version;
            AccessToken = accessToken;
            XX = xX;
            UserType = userType;
            NativesPath = nativesPath;
            LauncherBrand = launcherBrand;
            Libraries = libraries;
        }

        public static LaunchArguments Empty()
        {
            return new LaunchArguments();
        }

        public string GetAccessToken()
        {
            return AccessToken;
        }

        public string GetAssetIndex()
        {
            return AssetIndex;
        }

        public string GetAsssetDirectory()
        {
            return AssetsDirectory;
        }

        public string GetGameDirectory()
        {
            return GameDirectory;
        }

        public string GetGameExecutable()
        {
            return GameExecutable;
        }

        public int GetHeight()
        {
            return Height;
        }

        public string GetLauncherBrand()
        {
            return LauncherBrand;
        }

        public int GetLauncherVersion()
        {
            return LauncherVersion;
        }

        public string[] GetLibraries()
        {
            return Libraries;
        }

        public string GetMainClass()
        {
            return MainClass;
        }

        public string GetNativesPath()
        {
            return NativesPath;
        }

        public string GetUsername()
        {
            return Username;
        }

        public string GetUserType()
        {
            return UserType;
        }

        public string GetUUID()
        {
            return UUID;
        }

        public string GetVersion()
        {
            return Version;
        }

        public string GetVersionType()
        {
            return VersionType;
        }

        public int GetWidth()
        {
            return Width;
        }

        public int GetXms()
        {
            return Xms;
        }

        public int GetXmx()
        {
            return Xmx;
        }

        public string GetXX()
        {
            return XX;
        }

        public void SetAccessToken(string arg)
        {
            AccessToken = arg;
        }

        public void SetAssetIndex(string arg)
        {
            AssetIndex = arg;
        }

        public void SetAssetsDirectory(string arg)
        {
            AssetsDirectory = arg;
        }

        public void SetGameDirectory(string arg)
        {
            GameDirectory = arg;
        }

        public void SetGameExecutable(string arg)
        {
            GameExecutable = arg;
        }

        public void SetHeight(int arg)
        {
            Height = arg;
        }

        public void SetLauncherBrand(string arg)
        {
            LauncherBrand = arg;
        }

        public void SetLauncherVersion(int arg)
        {
            LauncherVersion = arg;
        }

        public void SetLibraries(string[] arg)
        {
            Libraries = arg;
        }

        public void SetMainClass(string arg)
        {
            MainClass = arg;
        }

        public void SetNativesPath(string arg)
        {
            NativesPath = arg;
        }

        public void SetUsername(string arg)
        {
            Username = arg;
        }

        public void SetUserType(string arg)
        {
            UserType = arg;
        }

        public void SetUUID(string arg)
        {
            UUID = arg;
        }

        public void SetVersion(string arg)
        {
            Version = arg;
        }

        public void SetVersionType(string arg)
        {
            VersionType = arg;
        }

        public void SetWidth(int arg)
        {
            Width = arg;
        }

        public void SetXms(int arg)
        {
            Xms = arg;
        }

        public void SetXmx(int arg)
        {
            Xmx = arg;
        }

        public void SetXX(string arg)
        {
            XX = arg;
        }
    }
}