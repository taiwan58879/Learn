using Learn.DependencyInjection.Interfaces;

namespace Learn.DependencyInjection.Extensions
{
    public static class IContainerRegistryExtension
    {
        public static IContainerRegistry Register<T>(this IContainerRegistry containerRegistry)
        {
            return containerRegistry.Register(typeof(T));
        }
        public static IContainerRegistry Register<TFrom, TTo>(this IContainerRegistry containerRegistry) where TTo : TFrom
        {
            return containerRegistry.Register(typeof(TFrom), typeof(TTo));
        }
        public static IContainerRegistry RegisterInstance<T>(this IContainerRegistry containerRegistry, T instance)
        {
            return instance == null ? containerRegistry : containerRegistry.RegisterInstance(typeof(T), instance);
        }
        public static IContainerRegistry RegisterSingleton<TFrom, TTo>(this IContainerRegistry containerRegistry) where TTo : TFrom
        {
            return containerRegistry.RegisterSingleton(typeof(TFrom), typeof(TTo));
        }
        public static IContainerRegistry RegisterSingleton<T>(this IContainerRegistry containerRegistry)
        {
            return containerRegistry.RegisterSingleton(typeof(T), typeof(T));
        }
    }
}
