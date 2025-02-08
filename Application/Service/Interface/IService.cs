using Core.Entity.Base;

namespace Application.Service.Interface;
public interface IService<T> where T : BaseEntity
{
    Task<IList<T>> GetAllAsync();
    Task<T?> GetByIdAsync(int id);
    Task CreateAsync(T entity);
    Task EditAsync(T entity);
    Task DeleteAsync(T entity);
}
