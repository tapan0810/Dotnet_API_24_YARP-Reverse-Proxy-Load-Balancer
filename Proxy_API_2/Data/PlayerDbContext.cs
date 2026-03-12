using Proxy_API_2.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Proxy_API_2.Data
{
    public class PlayerDbContext:DbContext
    {
        public PlayerDbContext(DbContextOptions<PlayerDbContext> options) : base(options) { }
        public DbSet<Player> Players => Set<Player>();
    }
}
