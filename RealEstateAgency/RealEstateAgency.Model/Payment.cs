using Newtonsoft.Json;
using System;

namespace RealEstateAgency.Model
{
    public class Payment
    {
        public string Id { get; set; }

        public decimal Amount { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public DateTime Created { get; set; }

        public string CreatedFormatted => Created.ToString("dd.MM.yyyy HH.mm");
    }
}