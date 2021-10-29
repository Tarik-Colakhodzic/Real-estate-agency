using System.Collections.Generic;

namespace RealEstateAgency.Database
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<City> Cities { get; set; }
    }
}