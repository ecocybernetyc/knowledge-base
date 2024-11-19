using PostgresEntityFramework.Model;

namespace PostgresEntityFramework.Repositories;

public interface IProfessionRepository
{
    Task<IEnumerable<Profession>> GetProfessionsAsync();
    Task<Profession?> GetProfessionAsync(Guid id);
    Task<Profession?> CreateProfessionAsync(Profession profession);
    Task<Profession?> UpdateProfessionAsync(Profession profession);
    Task<bool> DeleteProfessionAsync(Guid id);
}
