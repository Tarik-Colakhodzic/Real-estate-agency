using System.Collections.Generic;

namespace RealEstateAgency.Services
{
    public interface IReadService<T, TSearch> where T : class where TSearch : class
    {
        IEnumerable<T> Get(TSearch search = null);

        public T GetById(int id);
    }
}