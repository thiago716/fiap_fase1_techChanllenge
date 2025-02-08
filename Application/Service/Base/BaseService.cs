using Application.Service.Interface;
using Core.Entity.Base;
using Core.Repository.Interface;

namespace Application.Service.Base;
public abstract class BaseService<T> : IService<T> where T : BaseEntity
{
    protected readonly IRepository<T> _repository;

    protected BaseService(IRepository<T> repository)
    {
        _repository = repository;
    }

    public virtual async Task<IList<T>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public virtual async Task<T?> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public virtual async Task CreateAsync(T entity)
    {
        await _repository.CreateAsync(entity);
    }
    public virtual async Task EditAsync(T entity)
    {
        await _repository.EditAsync(entity);
    }

    public virtual async Task DeleteAsync(T entity)
    {
        await _repository.DeleteAsync(entity);
    }
}
