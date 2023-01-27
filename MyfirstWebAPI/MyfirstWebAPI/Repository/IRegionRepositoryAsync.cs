using MyfirstWebAPI.Model.Domain;

namespace MyfirstWebAPI.Repository
{
    public interface IRegionRepositoryAsync
    {
        Task<IEnumerable<Region>> GetAllAsync();
    }
}
