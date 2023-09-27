using Models.Domain;

namespace Domain.Interfaces;

public interface ITableRepository : IRepository<DbTable>
{
    public Task<DbTable?> GetAvailableByPeopleCapacity(int peopleAmount);
}