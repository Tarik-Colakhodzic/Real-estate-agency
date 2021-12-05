namespace RealEstateAgency.Services
{
    public interface IVisitService : ICRUDService<Model.Visit, Model.Requests.VisitSearchRequest, Model.Visit, Model.Visit>
    {
        public bool SetApproved(int id, bool approved);
    }
}