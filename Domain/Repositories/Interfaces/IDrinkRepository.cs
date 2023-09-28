using Models.Domain;

namespace Domain.Repositories.Interfaces;

public interface IDrinkRepository : IRepository<DbDrink>
{
    public Task<IEnumerable<DbDrink>> Get(IEnumerable<int> ids);

    public Task<IEnumerable<DbDrink>> GetAll();

    public Task<DbDrink> Get(int id);

    public Task<DbDrink> Add(DbDrink model);

    public Task<IEnumerable<DbEmployee>> AddRange(IEnumerable<DbDrink> dbEmployees);
}