using System.Linq;
using SandstoneLauncher.Minecraft.Interfaces;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class HashCombiner : IHashCombiner
    {
        public string GetFirstLetters(string hash)
        {
            char[] array = hash.ToArray();
            string output = "";

            for (int i = 0; i < 2; i++) output += array[i];

            return output;
        }
    }
}