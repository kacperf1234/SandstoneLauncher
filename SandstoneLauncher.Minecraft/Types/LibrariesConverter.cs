using System.Collections.Generic;
using System.Text;
using SandstoneLauncher.Minecraft.Enums;
using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class LibrariesConverter : ILibrariesConverter
    {
        public IPathConverter Converter;
        public ILibraryFileChecker LibraryChecker;
        public ILibraryValidator LibraryValidator;
        public IMinecraftDirectory MinecraftDirectory;
        public ILibraryPathBuilder PathBuilder;

        public LibrariesConverter(IMinecraftDirectory minecraftDirectory, IPathConverter converter,
            ILibraryPathBuilder builder, ILibraryFileChecker checker, ILibraryValidator validator)
        {
            MinecraftDirectory = minecraftDirectory;
            Converter = converter;
            PathBuilder = builder;
            LibraryChecker = checker;
            LibraryValidator = validator;
        }

        public string Convert(string[] libs)
        {
            StringBuilder b = new StringBuilder();

            foreach (string lib in libs)
                if (LibraryChecker.CheckFile(lib))
                    b.Append(lib + ";");

            string result = b.ToString();
            return result;
        }

        public string[] ToStringArray(Library[] libs, OS sys)
        {
            List<string> list = new List<string>();

            foreach (Library lib in libs)
            {
                if (!LibraryValidator.Validate(lib, sys))
                    continue;

                string toadd = PathBuilder.Build(lib);
                list.Add(toadd);
            }

            return list.ToArray();
        }
    }
}