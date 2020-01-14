using System;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Interfaces
{
    public interface IContainerDelegateTypeValidator
    {
        bool Validate(Type type);
    }
}