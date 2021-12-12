using System;

namespace RealEstateAgency.Model.Requests
{
    public class ContractSearchRequest
    {
        public string PropertyTitle { get; set; }
        public int? AgentId { get; set; }
        public int? OwnerId { get; set; }
        public int? ClientId { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public string[] IncludeList { get; set; }
    }
}