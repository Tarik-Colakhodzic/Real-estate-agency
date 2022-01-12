using System;

namespace RealEstateAgency.Model
{
    public class BookOfComplaints
    {
        public int Id { get; set; }
        public int? AgentId { get; set; }
        public virtual Agent Agent { get; set; }
        public string Comment { get; set; }
        public DateTime DateCreated { get; set; }
        public string DateCreatedFormated => DateCreated.ToString("dd.MM.yyyy");

        public string AgentName => $"{Agent?.User?.FirstName} {Agent?.User?.LastName}";
    }
}