using Learn.DependencyInjection.Interfaces;
using Learn.DependencyInjection.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Learn.DependencyInjection
{
    public static class Entry
    {
        public static IContainerRegistry GetContainerRegistry()
        {
            return new Container();
        }
        public static IContainerRegistry GetContainerRegistry(IServiceCollection serviceCollection)
        {
            return new Container(serviceCollection);
        }
    }
}
