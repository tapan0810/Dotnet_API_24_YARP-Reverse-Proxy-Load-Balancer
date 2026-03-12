using Dotnet_API_24_YARP_Reverse_Proxy_Load_Balancer.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_API_24_YARP_Reverse_Proxy_Load_Balancer.Data
{
    public class PlayerDbContext:DbContext
    {
        public PlayerDbContext(DbContextOptions<PlayerDbContext> options) : base(options) { }
        public DbSet<Player> Players => Set<Player>();
    }
}
