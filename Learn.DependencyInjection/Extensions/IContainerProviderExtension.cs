using Learn.DependencyInjection.Interfaces;

namespace Learn.DependencyInjection.Extensions
{
    public static class IContainerProviderExtension
    {
        public static T Resolve<T>(this IContainerProvider containerProvider)
        {
            if (containerProvider.Resolve(typeof(T)) is T t)
            {
                return t;
            }
            else
            {
                throw new System.InvalidOperationException($"{typeof(T).Name} not registered.");
            }
        }
    }
}
