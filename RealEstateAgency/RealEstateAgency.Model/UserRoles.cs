using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateAgency.Model
{
    public class UserRoles
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        //public virtual User User { get; set; }
        //public virtual Role Role { get; set; }
    }
}
