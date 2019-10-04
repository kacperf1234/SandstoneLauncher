namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface ILaunchArguments
    {
        #region methods: get

        int GetXmx();

        int GetXms();

        int GetWidth();

        int GetHeight();

        string GetGameExecutable();

        string GetVersionType();

        string GetUUID();

        string GetGameDirectory();

        string GetAsssetDirectory();

        string GetUsername();

        string GetMainClass();

        string GetAssetIndex();

        string GetVersion();

        string[] GetLibraries();

        string GetAccessToken();

        string GetXX();

        string GetUserType();

        string GetLauncherBrand();

        string GetNativesPath();

        int GetLauncherVersion();

        #endregion


        #region methods: set

        void SetXmx(int arg);

        void SetXms(int arg);

        void SetWidth(int arg);

        void SetHeight(int arg);

        void SetGameExecutable(string arg);

        void SetVersionType(string arg);

        void SetUUID(string arg);

        void SetGameDirectory(string arg);

        void SetAssetsDirectory(string arg);

        void SetUsername(string arg);

        void SetMainClass(string arg);

        void SetAssetIndex(string arg);

        void SetVersion(string arg);

        void SetLibraries(string[] arg);

        void SetAccessToken(string arg);

        void SetXX(string arg);

        void SetUserType(string arg);

        void SetLauncherBrand(string arg);

        void SetNativesPath(string arg);

        void SetLauncherVersion(int arg);

        #endregion
    }
}