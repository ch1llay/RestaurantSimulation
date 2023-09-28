using Models.Domain;

namespace Domain.Repositories.Interfaces;

public interface ITableRepository : IRepository<DbTable>
{
    public Task<DbTable?> GetAvailableByPeopleCapacity(int peopleAmount);
}