using System;

namespace RealEstateAgency.Model
{
    public class Contract
    {
        public int Id { get; set; }
        public virtual Property Property { get; set; }
        public int AgentId { get; set; }
        public virtual Agent Agent { get; set; }
        public int UserId { get; set; }
        public virtual User Client { get; set; }
        public DateTime DateCreated { get; set; }
        public string ContractNumber { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}