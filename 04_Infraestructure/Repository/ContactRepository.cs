using Core.Entity;
using Core.Repository.Interface;
using Infraestructure.Configuration;
using Infraestructure.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repository;
public class ContactRepository : BaseRepository<Contact>, IContactRepository
{
    public ContactRepository(DataContext dataContext) : base(dataContext)
    {
    }

    public async Task<IList<Contact>> GetAllByDddAsync(int dddId)
    {
        var contacts = await _dbSet
                    .AsNoTracking()
                    .Include(x => x.Ddd)
                    .Where(x => x.Ddd != null && x.Ddd.Id == dddId)
                    .ToListAsync();

        return contacts;
    }
}
