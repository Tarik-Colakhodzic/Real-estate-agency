namespace RealEstateAgency.Model
{
    public class SimpleSearchRequest
    {
        public string SearchText { get; set; }
        public string[] IncludeList { get; set; }
    }
}