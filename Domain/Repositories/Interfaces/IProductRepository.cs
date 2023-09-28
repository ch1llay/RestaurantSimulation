using Models.Domain;

namespace Domain.Repositories.Interfaces;

public interface IProductRepository : IRepository<DbProduct>
{
    public DbProduct GetByName(string name);
}