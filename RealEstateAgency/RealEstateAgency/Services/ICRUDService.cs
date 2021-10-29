﻿namespace RealEstateAgency.Services
{
    public interface ICRUDService<T, TSearch, TInsert, TUpdate> : IReadService<T, TSearch> where T : class where TSearch : class where TInsert : class where TUpdate : class
    {
        T Insert(TInsert request);

        T Update(int id, TUpdate request);
    }
}