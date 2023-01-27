using Microsoft.EntityFrameworkCore;
using MyfirstWebAPI.Data;
using MyfirstWebAPI.Model.Domain;

namespace MyfirstWebAPI.Repository
{
    public class RegionRepository:IRegionRepository
    {
        private readonly NZWalksDBContext nZWalksDBContext;
        public RegionRepository(NZWalksDBContext nZWalksDBContext)
        {
            this.nZWalksDBContext = nZWalksDBContext;
        }
        public IEnumerable<Region> GetAll()
        { 
            return nZWalksDBContext.Regions.ToList();
        }
        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            return await nZWalksDBContext.Regions.ToListAsync();
        }
    }
}
