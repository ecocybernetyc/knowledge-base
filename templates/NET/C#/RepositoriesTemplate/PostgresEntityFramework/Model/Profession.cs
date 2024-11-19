namespace PostgresEntityFramework.Model;

public class Profession
{
    public Guid Id { get; init; }
    public string? Name { get; init; }
    public EducationLevel MinEducationLevel { get; init; }
    public IEnumerable<Skill>? Skills { get; init; }
}
