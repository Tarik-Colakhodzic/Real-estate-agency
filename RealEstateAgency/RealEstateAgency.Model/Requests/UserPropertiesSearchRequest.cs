using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateAgency.Model.Requests
{
    public class UserPropertiesSearchRequest
    {
        public int? UserId { get; set; }
        public int? PropertyId { get; set; }
        public bool? Finished { get; set; }
        public string[] IncludeList { get; set; }
    }
}
