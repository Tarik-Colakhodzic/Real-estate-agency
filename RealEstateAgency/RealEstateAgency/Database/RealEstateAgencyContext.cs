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
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<OfferType> OfferTypes { get; set; }
        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<PropertyPhoto> PropertyPhotos { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<BookOfComplaints> BookOfComplaints { get; set; }
        public virtual DbSet<Visit> Visits { get; set; }
        public virtual DbSet<UserProperties> UserProperties { get; set; }
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }
    }
}