using Models.Domain;

namespace Domain.Repositories.Interfaces;

public interface IRepository<T>
{
    public Task<IEnumerable<T>> Get(IEnumerable<int> ids);
    public Task<IEnumerable<T>> GetAll();
    public Task<T> Get(int id);
    public Task<T> Add(T model);
    public Task<IEnumerable<T>> AddRange(IEnumerable<T> dbEmployees);
}