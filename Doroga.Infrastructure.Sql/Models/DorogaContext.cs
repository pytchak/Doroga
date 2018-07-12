using Microsoft.EntityFrameworkCore;

namespace Doroga.Infrastructure.Sql.Models
{
    class DorogaContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
    }
}
