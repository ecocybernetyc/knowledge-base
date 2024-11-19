namespace RepositoryCommon.Configuration;

public class PostgresConfiguration
{
    public const string SectionName = "Postgres";

    public string? ConnectionString { get; set; }
}
