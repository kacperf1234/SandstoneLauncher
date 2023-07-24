using System.Linq;
using System.Text;
using SandstoneLauncher.Minecraft.Interfaces;

namespace SandstoneLauncher.Minecraft.Types
{
    public class FileNameRemover : IFileNameRemover
    {
        public string Remove(string path)
        {
            path = path.Replace(@"\", "/");
            string[] segments = path.Split("/".ToCharArray()[0]);

            if (segments.Length > 1)
            {
                StringBuilder builder = new StringBuilder();

                foreach (string segment in segments)
                {
                    if (segment == segments.Last())
                        break;

                    builder.Append(segment);
                    builder.Append("\\");
                }

                return builder.ToString();
            }

            return path;
        }
    }
}