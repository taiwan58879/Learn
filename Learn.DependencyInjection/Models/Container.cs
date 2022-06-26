using Learn.DependencyInjection.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Learn.DependencyInjection.Models
{
    class Container : IContainerProvider, IContainerRegistry
    {
        private readonly IServiceCollection serviceCollection;
        private IServiceProvider? serviceProvider;

        public Container() : this(new ServiceCollection())
        {

        }

        public Container(IServiceCollection serviceCollection)
        {
            this.serviceCollection = serviceCollection;
        }
        #region Register
        public IContainerRegistry RegisterInstance(Type type, object instance)
        {
            if (type != null && instance != null)
            {
                this.serviceCollection.AddSingleton(type, instance);
            }
            return this;
        }
        public IContainerRegistry Register(Type from, Type to)
        {
            if (from != null && to != null)
            {
                this.serviceCollection.AddTransient(from, to);
            }
            return this;
        }
        public IContainerRegistry RegisterSingleton(Type from, Type to)
        {
            this.serviceCollection.AddSingleton(from, to);
            return this;
        }
        public IContainerRegistry Register(Type type)
        {
            this.serviceCollection.AddTransient(type);
            return this;
        }
        #endregion Register

        #region Provider
        public object? Resolve(Type type)
        {
            return this.serviceProvider?.GetService(type);
        }
        public IContainerProvider CreateContainerProvider()
        {
            RegisterInstance(typeof(IContainerProvider), this);

            this.serviceProvider = this.serviceCollection.BuildServiceProvider();

            return this;
        }
        #endregion Provider
    }
}
