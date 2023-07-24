#region

using System.Net.Http;

#endregion

namespace KacpiiToZiomal.SandstoneLauncher.Minecraft.Interfaces
{
    public interface IResponseValidator
    {
        bool Validate(HttpResponseMessage r);
    }
}