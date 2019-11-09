using System;
using System.Linq;
using System.Threading.Tasks;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class AssetsDownloader : IAssetsDownloader
    {
        public IHttpDownloader Downloader;
        public IAssetsExtractor Extractor;
        public IAssetsIndexCreator IndexCreator;
        public IAssetsPathBuilder PathBuilder;
        public IAssetsUrlBuilder UrlBuilder;

        public AssetsDownloader(IAssetsExtractor extractor, IAssetsUrlBuilder urlBuilder, IHttpDownloader downloader,
            IAssetsPathBuilder pathBuilder, IAssetsIndexCreator creator)
        {
            Extractor = extractor;
            UrlBuilder = urlBuilder;
            Downloader = downloader;
            PathBuilder = pathBuilder;
            IndexCreator = creator;
        }

        public void Download(Assets assets, FullVersion version)
        {
            foreach (string key in assets.AssetList.Keys)
            {
                Asset asset = Extractor.Get(assets, key);
                string url = UrlBuilder.BuildUrl(asset.Hash);
                string dest = PathBuilder.GetAbsolutePath(asset.Hash);

                Downloader.DownloadAsync(url, dest);
            }

            IndexCreator.Create(assets.BaseJson, version.Assets);
        }

        public void Download(Asset asset)
        {
            string url = UrlBuilder.BuildUrl(asset.Hash);
            string dest = PathBuilder.GetAbsolutePath(asset.Hash);

            Downloader.Download(url, dest);
        }
    }
}