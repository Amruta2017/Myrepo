using Microsoft.EntityFrameworkCore;
using MyfirstWebAPI.Data;
using MyfirstWebAPI.Model.Domain;

namespace MyfirstWebAPI.Repository
{
    public  class RegionRepositoryAsync : IRegionRepositoryAsync
    {
        private readonly NZWalksDBContext nZWalksDBContext;
        public RegionRepositoryAsync(NZWalksDBContext nZWalksDBContext)
        {
            this.nZWalksDBContext = nZWalksDBContext;
        }
        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            return await nZWalksDBContext.Regions.ToListAsync();
        }
    }
}
