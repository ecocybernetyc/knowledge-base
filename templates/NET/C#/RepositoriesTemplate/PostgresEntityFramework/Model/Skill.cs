namespace PostgresEntityFramework.Model;

public class Skill
{
    public Guid Id { get; init; }
    public string? Name { get; init; }
    public IEnumerable<string>? Details { get; init; }
    
    public virtual Profession? Profession { get; init; }
}

