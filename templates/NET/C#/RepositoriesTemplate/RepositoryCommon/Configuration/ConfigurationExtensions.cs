using Microsoft.Extensions.Configuration;

namespace RepositoryCommon.Configuration;

public static class ConfigurationExtensions
{
    public static PostgresConfiguration GetPostgresConnectionString(this IConfiguration configuration)
    {
        var postgresConfiguration = new PostgresConfiguration();
        configuration.GetSection(PostgresConfiguration.SectionName).Bind(postgresConfiguration);
        return postgresConfiguration;
    }
}
