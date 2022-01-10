namespace RealEstateAgency.Model.Requests
{
    public class CountrySearchRequest
    {
        public int? CountryId { get; set; }
        public string[] IncludeList { get; set; }
    }
}