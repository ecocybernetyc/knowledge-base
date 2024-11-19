using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PostgresEntityFramework.Repositories;

namespace PostgresEntityFramework.Configuration;

public static class ServicesExtensions
{
    public static IServiceCollection AddProfessionRepository(this IServiceCollection services, string? connectionString)
    {
        services.AddDbContext<ProfessionDbContext>(options =>
        {
            options.UseNpgsql(connectionString);
        });
        services.AddScoped<IProfessionRepository, ProfessionRepository>();
        return services;
    }
}
