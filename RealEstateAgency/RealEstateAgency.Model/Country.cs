using System.Collections.Generic;

namespace RealEstateAgency.Model
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<City> Cities { get; set; }
    }
}