using RealEstateAgency.Model.Requests;

namespace RealEstateAgency.Services
{
    public interface IPropertyService : ICRUDService<Model.Property, PropertySearchRequest, Model.Property, Model.Property>
    {
        public bool SetFinished(int id, bool finished);

        public bool SetPaid(int id, bool paid, string chargeId);
    }
}