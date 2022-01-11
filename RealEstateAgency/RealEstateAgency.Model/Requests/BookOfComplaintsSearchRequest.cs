namespace RealEstateAgency.Model.Requests
{
    public class BookOfComplaintsSearchRequest
    {
        public int? AgentId { get; set; }
        public string[] IncludeList { get; set; }
    }
}