using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
