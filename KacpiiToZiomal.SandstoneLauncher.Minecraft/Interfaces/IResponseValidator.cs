using System.Net.Http;

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IResponseValidator
    {
        bool Validate(HttpResponseMessage r);
    }
}