using Models.Domain;

namespace Domain.Repositories.Interfaces;

public interface ITableRepository : IRepository<DbDbTable>
{
    public Task<DbDbTable?> GetAvailableByPeopleCapacity(int peopleAmount);
}