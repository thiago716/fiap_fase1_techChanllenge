using Core.Entity;

namespace Application.Service.Interface;
public interface IContactService : IService<Contact>
{
    Task<IList<Contact>> GetAllByDddAsync(int dddId);
}
