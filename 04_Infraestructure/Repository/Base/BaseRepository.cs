using Core.Entity.Base;
using Core.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using Infraestructure.Configuration;

namespace Infraestructure.Repository.Base;
public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
{
    protected DataContext _context;
    protected DbSet<T> _dbSet;

    public BaseRepository(DataContext dataContext)
    {
        _context = dataContext;
        _dbSet = _context.Set<T>();
    }
    public async Task<IList<T>> GetAllAsync()
    {
        return await _dbSet            
            .ToListAsync();
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        return await _dbSet            
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task CreateAsync(T entity)
    {
        entity.CreatedOn = DateTime.UtcNow;

        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task EditAsync(T entity)
    {
        _dbSet.Update(entity); // update não tem async
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        _dbSet.Remove(entity); // remove não tem async
        await _context.SaveChangesAsync();
    }
}
