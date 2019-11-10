﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Models;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class AssetsDownloader : IAssetsDownloader
    {
        public IHttpDownloader Downloader;
        public IAssetsExtractor Extractor; // TODO to remove
        public IAssetsListFilter AssetsFilter;
        public IAssetsIndexCreator IndexCreator;
        public IAssetsPathBuilder PathBuilder;
        public IAssetsUrlBuilder UrlBuilder;

        public AssetsDownloader(IAssetsExtractor extractor, IAssetsUrlBuilder urlBuilder, IHttpDownloader downloader,
            IAssetsPathBuilder pathBuilder, IAssetsIndexCreator creator, IAssetsListFilter assetsFilter)
        {
            Extractor = extractor;
            UrlBuilder = urlBuilder;
            Downloader = downloader;
            PathBuilder = pathBuilder;
            IndexCreator = creator;
            AssetsFilter = assetsFilter;
        }

        public void Download(Assets assets, FullVersion version)
        {
            IEnumerable<Asset> listAssets = AssetsFilter.Filter(assets);
            
            foreach (Asset asset in listAssets)
            {
                string path = PathBuilder.GetAbsolutePath(asset.Hash);
                string url = UrlBuilder.BuildUrl(asset.Hash);
                
                Downloader.DownloadAsync(url, path);
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