using System.Threading.Tasks;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;

namespace SandstoneLauncher.Minecraft.Types
{
    public class AsynchronousAssetsDownloader : IAssetsDownloader
    {
        public IHttpDownloader Downloader;
        public IAssetsExtractor Extractor;
        public IAssetsIndexCreator IndexCreator;
        public IAssetsPathBuilder PathBuilder;
        public IAssetsUrlBuilder UrlBuilder;

        public AsynchronousAssetsDownloader(IHttpDownloader downloader, IAssetsExtractor extractor,
            IAssetsIndexCreator indexCreator, IAssetsPathBuilder pathBuilder, IAssetsUrlBuilder urlBuilder)
        {
            Downloader = downloader;
            Extractor = extractor;
            IndexCreator = indexCreator;
            PathBuilder = pathBuilder;
            UrlBuilder = urlBuilder;
        }

        public void Download(Assets assets, FullVersion version)
        {
            Parallel.ForEach(assets.AssetList.Keys, kvp =>
            {
                Asset asset = Extractor.Get(assets, kvp);
                string targetpath = PathBuilder.GetAbsolutePath(asset.Hash);
                string targeturl = UrlBuilder.BuildUrl(asset.Hash);

                Downloader.Download(targeturl, targetpath);
            });

            IndexCreator.Create(assets.BaseJson, version.Assets);
        }
    }
}