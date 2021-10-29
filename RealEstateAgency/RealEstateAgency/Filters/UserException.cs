using System;

namespace RealEstateAgency.Filters
{
    public class UserException : Exception
    {
        public UserException(string message) : base(message)
        {
        }
    }
}