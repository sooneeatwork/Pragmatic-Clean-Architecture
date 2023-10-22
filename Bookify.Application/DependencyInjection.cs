using Bookify.Application.Abstractions.Behaviours;
using Bookify.Domain.Bookings;
using Microsoft.Extensions.DependencyInjection;

namespace Bookify.Application;

public static class DependencyInjection
{
    #region Public Methods

    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var assembly = typeof(DependencyInjection).Assembly;
        services.AddMediatR(configuration =>
                            {
                                configuration.RegisterServicesFromAssembly(assembly);
                                configuration.AddOpenBehavior(typeof(LoggingBehaviour<,>));
                            });
        services.AddAutoMapper(assembly);

        services.AddTransient<PricingService>();

        return services;
    }

    #endregion
}
