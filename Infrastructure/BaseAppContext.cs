using Microsoft.EntityFrameworkCore;

namespace BaseApp.Infrastructure
{
    public class BaseAppContext : DbContext
    {
        public BaseAppContext(DbContextOptions<BaseAppContext> options) : base(options)
        {
        }
        public DbSet<User> users { get; set; }
    }
}