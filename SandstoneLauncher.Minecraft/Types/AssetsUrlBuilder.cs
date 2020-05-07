﻿using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class AssetsUrlBuilder : IAssetsUrlBuilder
    {
        private readonly string Url = "http://resources.download.minecraft.net/{f}/{l}";

        public IHashCombiner HashCombiner;

        public AssetsUrlBuilder(IHashCombiner hashCombiner)
        {
            HashCombiner = hashCombiner;
        }

        public string BuildUrl(string hash)
        {
            return Url.Replace("{f}", HashCombiner.GetFirstLetters(hash)).Replace("{l}", hash);
        }
    }
}