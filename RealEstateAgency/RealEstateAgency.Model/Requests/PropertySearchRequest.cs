using System;

namespace RealEstateAgency.Model.Requests
{
    public class PropertySearchRequest
    {
        public string SearchText { get; set; }
        public int? AgentId { get; set; }
        public int? OwnerId { get; set; }
        public int? CityId { get; set; }
        public int? CountryId { get; set; }
        public int? CategoryId { get; set; }
        public int? OfferTypeId { get; set; }
        public bool? Finished { get; set; }
        public bool? Unfinished { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public string[] IncludeList { get; set; }
    }
}