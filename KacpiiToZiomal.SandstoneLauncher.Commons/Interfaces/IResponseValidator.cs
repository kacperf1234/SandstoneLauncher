#region

using System.Net.Http;

#endregion

namespace KacpiiToZiomal.SandstoneLauncher.Commons.Interfaces
{
    public interface IResponseValidator
    {
        bool Validate(HttpResponseMessage r);
    }
}