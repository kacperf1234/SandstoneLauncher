using System.Linq;
using KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
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