﻿using Newtonsoft.Json;

namespace SandstoneLauncher.Minecraft.Models
{
    public class Resolution
    {
        [JsonProperty("width")]
        public int Width { get; set; }
        
        [JsonProperty("height")]
        public int Height { get; set; }
    }
}