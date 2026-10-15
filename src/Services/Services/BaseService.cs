using Infra.Repository;

namespace Services.Services;

public class BaseService<T> where T : class
{
    protected readonly BaseRepository<T> _baseRepository;

    protected BaseService(BaseRepository<T> repository)
    {
        _baseRepository = repository;
    }

    public virtual Task<T> Add(T entity)
    {
       return _baseRepository.AddAsync(entity);
    }
    
    public virtual Task<T> AddAsync(T entity)

    {

        return _baseRepository.AddAsync(entity);

    }

    public virtual Task<bool> DeleteAsync(string id)

    {

        return _baseRepository.DeleteAsync(id);

    }

    public virtual Task<T?> UpdateAsync(string id, T entity)

    {

        return _baseRepository.UpdateAsync(id, entity);

    }

    public virtual Task<T?> GetByIdAsync(string id)

    {

        return _baseRepository.GetByIdAsync(id);

    }

    public virtual Task<List<T>> GetAllAsync()

    {

        return _baseRepository.GetAllAsync();

    }
    
}