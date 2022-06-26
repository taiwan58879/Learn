using System;

namespace Learn.DependencyInjection.Interfaces
{
    public interface IContainerRegistry
    {
        IContainerRegistry Register(Type type);
        IContainerRegistry RegisterInstance(Type type, object instance);
        IContainerRegistry Register(Type from, Type to);
        IContainerRegistry RegisterSingleton(Type from, Type to);
        IContainerProvider CreateContainerProvider();
    }
}
