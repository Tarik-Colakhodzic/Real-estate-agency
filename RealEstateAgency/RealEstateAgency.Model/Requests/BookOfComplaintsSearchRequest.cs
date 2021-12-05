namespace RealEstateAgency.Model.Requests
{
    public class BookOfComplaintsSearchRequest
    {
        public string PropertyTitle { get; set; }
        public int? AgentId { get; set; }
        public string[] IncludeList { get; set; }
    }
}