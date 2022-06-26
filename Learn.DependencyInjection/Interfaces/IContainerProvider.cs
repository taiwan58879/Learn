using System;

namespace Learn.DependencyInjection.Interfaces
{
    public interface IContainerProvider
    {
        object? Resolve(Type type);
    }
}
