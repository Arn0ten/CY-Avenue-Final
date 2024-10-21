using System;

namespace CarlosYulo
{
    public static class ServiceLocator
    {
        public static IServiceProvider ServiceProvider { get; set; }

        public static T GetService<T>()
        {
            if (ServiceProvider == null)
            {
                throw new InvalidOperationException(
                    "ServiceProvider is not initialized. Please set it before accessing services.");
            }

            return (T)ServiceProvider.GetService(typeof(T))
                   ?? throw new InvalidOperationException($"Service of type {typeof(T)} is not registered.");
        }
    }
}