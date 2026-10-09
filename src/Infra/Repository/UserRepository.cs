using Domain.Entities;
using Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repository;

public class UserRepository : BaseRepository<User>
{
    public UserRepository(AppDbContext dbContext) : base(dbContext) {}

    public async Task<User?> GetUserByEmailAsync(string email)
    {
        var user = await _dbContext.Set<User>()
            .FirstOrDefaultAsync(x => x.Email == email);
        
        return user ?? null;
    }
}