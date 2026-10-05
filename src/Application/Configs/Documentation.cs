using Scalar.AspNetCore;

namespace Application.Configs;

public static class Documentation
{
    public static IServiceCollection AddDocumentation(this IServiceCollection services)
    {
        services.AddOpenApi();
        
        return services;
    }

    public static WebApplication UseDocumentation(this WebApplication app)
    {
        app.MapOpenApi();
        app.MapScalarApiReference("/docs");
        
        return app;
    }
}