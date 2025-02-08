using Core.Entity;
using Core.Repository.Interface;
using Infraestructure.Configuration;
using Infraestructure.Repository.Base;

namespace Infraestructure.Repository;
public class DirectDistanceDialingRepository : BaseRepository<DirectDistanceDialing>, IDirectDistanceDialingRepository
{
    public DirectDistanceDialingRepository(DataContext dataContext) : base(dataContext)
    {
    }
}
