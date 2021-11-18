using System.Collections.Generic;

namespace RealEstateAgency.Model
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}