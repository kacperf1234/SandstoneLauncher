using System.Linq;
using System.Threading.Tasks;
using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using SandstoneLauncher.Minecraft.Types;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Cli.Services.Download
{
    [SingleInstance]
    public class DownloadService
    {
        [Inject]
        public AssetsDownloader AssetsDownloader;
        
        [Inject]
        public IFullVersionFinder FullVersionFinder;
        
        [Inject]
        public ManifestGetter ManifestGetter;
        
        [Inject]
        public AssetsFinder AssetsFinder;

        [Inject]
        public GameFilesDownloader GameFilesDownloader; // TODO: Replace with AsynchronousGameFilesDownloader
        
        public Task<bool> DownloadAssets(string versionId)
        {
            return Task.Run(() =>
            {
                try
                {
                    var versionUrl = ManifestGetter.GetManifest().Versions.FirstOrDefault(v => v.Id == versionId).Url;
                    var fullVersion = FullVersionFinder.Find(versionUrl);
                    var assets = AssetsFinder.GetAssets(fullVersion.AssetsIndex.Url, fullVersion);
                    AssetsDownloader.Download(assets, fullVersion);
                    return true;
                }

                catch
                {
                    return false;
                }
            });
        }

        public Task<bool> DownloadGame(string versionId, OS sys)
        {
            try
            {
                var gameVersion = ManifestGetter.GetManifest().Versions.FirstOrDefault(x => x.Id == versionId);
                GameFilesDownloader.Download(gameVersion, sys);
                return Task.FromResult(true);
            }

            catch
            {
                return Task.FromResult(false);
            }
        }
    }
}