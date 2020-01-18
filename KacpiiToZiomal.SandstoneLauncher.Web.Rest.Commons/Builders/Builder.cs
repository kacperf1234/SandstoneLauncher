using System;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Builders
{
    public class Builder<TBuilder, TOut>
        where TBuilder : Builder<TBuilder, TOut>
        where TOut : class
    {
        private protected TOut Instance;

        public Builder()
        {
        }

        public Builder(TOut instance)
        {
            Instance = instance;
        }

        public TBuilder InitializeBuilder()
        {
            Instance = Activator.CreateInstance<TOut>();

            return NewBuilder(Instance);
        }

        private TBuilder NewBuilder(TOut instance)
        {
            return (TBuilder) Activator.CreateInstance(typeof(TBuilder), instance);
        }

        protected TBuilder Update(Action<TOut> action)
        {
            action(Instance);

            return NewBuilder(Instance);
        }

        public TOut Build()
        {
            return Instance;
        }
    }
}