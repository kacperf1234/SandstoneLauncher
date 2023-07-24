using System.Linq;
using SandstoneLauncher.Minecraft.Interfaces;

namespace SandstoneLauncher.Minecraft.Types
{
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