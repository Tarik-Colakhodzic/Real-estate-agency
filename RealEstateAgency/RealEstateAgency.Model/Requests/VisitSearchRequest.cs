namespace RealEstateAgency.Model.Requests
{
    public class VisitSearchRequest
    {
        public string PropertyTitle { get; set; }
        public int? PropertyId { get; set; }
        public bool Approved { get; set; }
        public bool NotApproved { get; set; }
        public int? ClientId { get; set; }
        public string[] IncludeList { get; set; }
    }
}