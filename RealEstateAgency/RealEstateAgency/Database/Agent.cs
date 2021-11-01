using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstateAgency.Database
{
    public class Agent
    {
        [Key, ForeignKey("User")]
        public int Id { get; set; }
        public User User { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public byte[] Photo { get; set; }
    }
}