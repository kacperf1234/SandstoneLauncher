using System;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Interfaces
{
    public interface IDatabaseUpdater<T>
    {
        void Update(string id, Action<T> act);

        void Update(string id, Action<T> act, out T t);
    }
}