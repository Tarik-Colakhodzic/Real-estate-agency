using System;

namespace RealEstateAgency.Database
{
    public class ErrorLog
    {
        public int Id { get; set; }
        public string StackTrace { get; set; }
        public string ExceptionMessage { get; set; }
        public string InnerExceptionMessage { get; set; }
        public DateTime DateTime { get; set; }
    }
}