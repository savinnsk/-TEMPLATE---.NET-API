using Infra.Database;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repository;

public class BaseRepository<T> where T : class
{
    protected readonly AppDbContext _dbContext;
    private readonly DbSet<T> _dbSet;

    public BaseRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<T>();
    }
    
    public async Task<T> AddAsync(T entity){
        _dbSet.Add(entity);
        await _dbContext.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> DeleteAsync(string id)
    {
        var entity = await _dbSet.FindAsync(id);

        if (entity == null) return false;
            
        _dbSet.Remove(entity);
        await _dbContext.SaveChangesAsync();
        
        return true;
    }

    public async Task<T?> UpdateAsync(string id, T entity)
    {
        var alreadyExists = await _dbSet.FindAsync(id);
        if (alreadyExists == null) return null;
        
        _dbContext.Entry(alreadyExists).CurrentValues.SetValues(entity);
        await _dbContext.SaveChangesAsync();
        return entity;
    }

    public async Task<T?> GetByIdAsync(string id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }
    
}