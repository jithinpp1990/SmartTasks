namespace SmartTasks.Data.DIExtention;

using Microsoft.Extensions.DependencyInjection;
using SmartTasks.Data.Implimentation;
using SmartTasks.Data.Interface;

/// <summary>
/// DataDIExtention class provides extension methods for dependency injection related to data access.
/// It can be used to register data access services in the dependency injection container.
/// </summary>
public static class DataDIExtention
{
    /// <summary>
    /// Adds data access services to the specified IServiceCollection.
    /// </summary>
    /// <param name="services">The IServiceCollection to which the data access services will be added.</param>
    /// <returns>The updated IServiceCollection with data access services registered.</returns>
    public static IServiceCollection AddDataServices(IServiceCollection services)
    {
        services.AddTransient<ITaskRepository, TaskRepository>();
        return services;
    }
}
