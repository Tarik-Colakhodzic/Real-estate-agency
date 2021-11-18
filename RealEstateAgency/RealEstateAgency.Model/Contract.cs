using System;

namespace RealEstateAgency.Model
{
    public class Contract
    {
        public int Id { get; set; }
        public virtual Property Property { get; set; }
        public string PropertyTitle => Property?.Title;
        public string PropertyOwnerName => Property?.Owner?.FullName;
        public int AgentId { get; set; }
        public virtual Agent Agent { get; set; }
        public string AgentName => $"{Agent?.User?.FirstName} {Agent?.User?.LastName}";
        public int UserId { get; set; }
        public virtual User Client { get; set; }
        public string ClientName => $"{Client?.FirstName} {Client?.LastName}";
        public DateTime DateCreated { get; set; }
        public string DateCreatedFormated => DateCreated.ToString("dd.MM.yyyy");
        public string ContractNumber { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}