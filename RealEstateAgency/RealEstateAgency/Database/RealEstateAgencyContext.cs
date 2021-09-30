using Microsoft.EntityFrameworkCore;

namespace RealEstateAgency.Database
{
    public class RealEstateAgencyContext : DbContext
    {
        public RealEstateAgencyContext(DbContextOptions<RealEstateAgencyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserRoles> UsersRoles { get; set; }
    }
}
