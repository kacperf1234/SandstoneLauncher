using System.IO;
using KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Types
{
    public class FileCreator : IFileCreator
    {
        public IFileNameRemover Remover;

        public FileCreator(IFileNameRemover remover)
        {
            Remover = remover;
        }

        public void Create(string path, string cnt)
        {
            Directory.CreateDirectory(Remover.Remove(path));

            FileStream s = File.Open(path, FileMode.OpenOrCreate);
            StreamWriter w = new StreamWriter(s);

            w.Write(cnt);
            w.Close();
            s.Close();
        }

        public void Create(string path, byte[] bytes)
        {
            Directory.CreateDirectory(Remover.Remove(path));

            using (FileStream stream = File.Open(path, FileMode.OpenOrCreate))
            {
                BinaryWriter bin = new BinaryWriter(stream);
                bin.Write(bytes);

                bin.Close();
                stream.Close();
            }
        }
    }
}