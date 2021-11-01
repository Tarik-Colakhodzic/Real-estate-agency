using System;
using System.Collections.Generic;

namespace RealEstateAgency.Model
{
    public class Agent
    {
        public int Id { get; set; }
        //public User User { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public byte[] Photo { get; set; }
    }
}