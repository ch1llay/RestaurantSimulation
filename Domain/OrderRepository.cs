﻿using Domain.Interfaces;
using Models.DbModels;

namespace Domain;

public class OrderRepository : IOrderRepository
{
    public Task<IEnumerable<DbEmployee>> AddRange(IEnumerable<DbOrder> models)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<DbOrder> GetByTableNumber(int tableNumber)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DbOrder>> Get(IEnumerable<int> ids)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DbOrder>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<DbOrder> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<DbOrder> Add(DbOrder model)
    {
        throw new NotImplementedException();
    }
}