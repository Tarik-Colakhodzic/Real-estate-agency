namespace RealEstateAgency.Services
{
    public interface IVisitService : ICRUDService<Model.Visit, Model.SimpleSearchRequest, Model.Visit, Model.Visit>
    {
        public bool SetApproved(int id, bool approved);
    }
}