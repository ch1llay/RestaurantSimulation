using Models.Domain;

namespace Domain.Repositories.Interfaces;

public class IDrinkRepository : IRepository<DbDrink>
{
    public Task<IEnumerable<DbDrink>> Get(IEnumerable<int> ids)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DbDrink>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<DbDrink> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<DbDrink> Add(DbDrink model)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DbEmployee>> AddRange(IEnumerable<DbDrink> dbEmployees)
    {
        throw new NotImplementedException();
    }
}