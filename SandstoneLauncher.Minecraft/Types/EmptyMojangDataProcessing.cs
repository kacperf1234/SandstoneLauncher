using SandstoneLauncher.Minecraft.Interfaces;
using SandstoneLauncher.Minecraft.Models;
using Spencer.NET;

namespace SandstoneLauncher.Minecraft.Types
{
    [SingleInstance]
    public class EmptyMojangDataProcessing : IDataProcessing<MojangData>
    {
        public void SendData(MojangData arg)
        {
            throw new System.NotImplementedException();
        }
    }
}