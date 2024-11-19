using Microsoft.EntityFrameworkCore;
using PostgresEntityFramework.Model;

namespace PostgresEntityFramework.Repositories;

public class ProfessionRepository(ProfessionDbContext dbContext) : IProfessionRepository
{
    private readonly ProfessionDbContext _dbContext = dbContext;

    public async Task<Profession?> CreateProfessionAsync(Profession profession)
    {
        _dbContext.Professions.Add(profession);
        await _dbContext.SaveChangesAsync();
        return profession;
    }

    public async Task<bool> DeleteProfessionAsync(Guid id)
        => await _dbContext.Professions.Where(x => x.Id == id).ExecuteDeleteAsync() > 0; 

    public async Task<Profession?> GetProfessionAsync(Guid id)
        => await _dbContext.Professions.FindAsync(id);

    public async Task<IEnumerable<Profession>> GetProfessionsAsync()
        => await _dbContext.Professions.ToListAsync();

    public async Task<Profession?> UpdateProfessionAsync(Profession profession)
    {
        _dbContext.Professions.Update(profession);
        await _dbContext.SaveChangesAsync();
        return profession;
    }
}
