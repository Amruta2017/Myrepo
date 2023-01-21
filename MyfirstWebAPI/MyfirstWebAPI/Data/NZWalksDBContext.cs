using Microsoft.EntityFrameworkCore;
using MyfirstWebAPI.Model.Domain;

namespace MyfirstWebAPI.Data
{
    public class NZWalksDBContext : DbContext
    {
        public NZWalksDBContext(DbContextOptions<NZWalksDBContext> options) : base(options)
        {

        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> walkDifficulty { get; set; }
    }
}
