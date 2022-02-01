using System;
using System.Collections.Generic;

namespace RealEstateAgency.Database
{
    public class Property
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public int SquareMeters { get; set; }
        public string Address { get; set; }
        public decimal Price { get; set; }
        public bool WaterConnection { get; set; }
        public bool ElectricityConnection { get; set; }
        public bool Finished { get; set; }
        public int? NumberOfBedRooms { get; set; }
        public int? NumberOfBathRooms { get; set; }
        public int? BalconySquareMeters { get; set; }
        public bool? Internet { get; set; }
        public bool Paid { get; set; }
        public DateTime PaymentDate { get; set; }
        public string ChargeId { get; set; }

        public int CityId { get; set; }
        public virtual City City { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int OfferTypeId { get; set; }
        public virtual OfferType OfferType { get; set; }
        public int AgentId { get; set; }
        public Agent Agent { get; set; }
        public int OwnerId { get; set; }
        public virtual Owner Owner { get; set; }
        public virtual ICollection<PropertyPhoto> PropertyPhotos { get; set; }
        public virtual ICollection<UserProperties> UserProperties { get; set; }
    }
}