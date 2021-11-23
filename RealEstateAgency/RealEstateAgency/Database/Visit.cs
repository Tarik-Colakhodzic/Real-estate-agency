using System;

namespace RealEstateAgency.Database
{
    public class Visit
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public virtual Property Property { get; set; }
        public int UserId { get; set; }
        public virtual User Client { get; set; }
        public DateTime DateTime { get; set; }
        public bool Approved { get; set; }
    }
}