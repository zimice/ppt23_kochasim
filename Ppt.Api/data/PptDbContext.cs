using Microsoft.EntityFrameworkCore;
using Ppt.Api.Data;

namespace Ppt.Api.data
{
    public class PptDbContext : DbContext
    {

        public PptDbContext(DbContextOptions options) : base(options) { 
            
        }
        public DbSet<Vybaveni> Vybavenis => Set<Vybaveni>();
    }
}
