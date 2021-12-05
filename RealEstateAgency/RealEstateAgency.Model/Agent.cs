using System;

namespace RealEstateAgency.Model
{
    public class Agent
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public byte[] Photo { get; set; }

        public string FullName => User?.FullName;
    }
}