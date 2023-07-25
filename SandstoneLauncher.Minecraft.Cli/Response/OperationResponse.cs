using System;
using Newtonsoft.Json;

namespace SandstoneLauncher.Minecraft.Cli.Response
{
    public class OperationResponse
    {
        [JsonProperty("op")]
        public string Operation { get; set; }
        
        [JsonProperty("data")]
        public object Data { get; set; }

        public static void PrintNew(string op, object data)
        {
            var r = new OperationResponse { Operation = op, Data = data };
            Console.WriteLine(JsonConvert.SerializeObject(r));
        }

        public static void Print(OperationResponse r)
        {
            Console.WriteLine(JsonConvert.SerializeObject(r));
        }
    }
}