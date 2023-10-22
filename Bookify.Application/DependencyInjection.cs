using Bookify.Domain.Bookings;
using Microsoft.Extensions.DependencyInjection;

namespace Bookify.Application;

public static class DependencyInjection
{
    #region Public Methods

    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(configuration => { configuration.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly); });

        services.AddTransient<PricingService>();

        return services;
    }

    #endregion
}
