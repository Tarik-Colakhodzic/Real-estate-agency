using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateAgency.Model
{
    public class Visit
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public virtual Property Property { get; set; }
        public int UserId { get; set; }
        public virtual User Client { get; set; }
        public DateTime DateTime { get; set; }
        public bool Approved { get; set; }

        public string ClientName => $"{Client.FirstName} {Client.LastName}";
        public string PropertyTitle => Property?.Title;
        public string DateTimeFormated => DateTime.ToString("dd.MM.yyy hh.mm");
    }
}
