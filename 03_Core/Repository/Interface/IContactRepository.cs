using Core.Entity;

namespace Core.Repository.Interface;
public interface IContactRepository : IRepository<Contact>
{
    Task<IList<Contact>> GetAllByDddAsync(int dddId);
}
