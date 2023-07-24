#region

using System.Net.Http;

#endregion

namespace SandstoneLauncher.Minecraft.Interfaces
{
    public interface IResponseValidator
    {
        bool Validate(HttpResponseMessage r);
    }
}