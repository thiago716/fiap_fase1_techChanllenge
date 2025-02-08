using Application.Service.Base;
using Application.Service.Interface;
using Core.Entity;
using Core.Repository.Interface;

namespace Application.Service;
public class ContactService : BaseService<Contact>, IContactService
{
    private readonly IContactRepository _contactRepository;
    private readonly IDirectDistanceDialingRepository _directDistanceDialingRepository;

    public ContactService(IContactRepository contactRepository, IDirectDistanceDialingRepository directDistanceDialingRepository) : base(contactRepository)
    {
        _contactRepository = contactRepository;
        _directDistanceDialingRepository = directDistanceDialingRepository; 
    }

    public async Task<IList<Contact>> GetAllByDddAsync(int dddId)
    {
        var ddd = await _directDistanceDialingRepository.GetByIdAsync(dddId);

        return ddd is null
            ? throw new ArgumentException("Invalid Direct Distance Dialing Id")
            : await _contactRepository.GetAllByDddAsync(dddId);
    }
}
