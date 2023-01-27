using MyfirstWebAPI.Model.Domain;

namespace MyfirstWebAPI.Repository
{
    public interface IRegionRepository
    {
       IEnumerable<Region> GetAll();
       Task<IEnumerable<Region>> GetAllAsync();
    }
    
}
