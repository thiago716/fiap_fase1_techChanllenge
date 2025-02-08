using Application.Service.Base;
using Application.Service.Interface;
using Core.Entity;
using Core.Repository.Interface;

namespace Application.Service;
public class DirectDistanceDialingService : BaseService<DirectDistanceDialing>, IDirectDistanceDialingService
{
    public DirectDistanceDialingService(IDirectDistanceDialingRepository repository) : base(repository)
    {        
    }
}
