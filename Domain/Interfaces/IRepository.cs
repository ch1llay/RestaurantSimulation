namespace Domain.Interfaces;

public interface IRepository<T>
{
    public Task<IEnumerable<T>> Get(IEnumerable<int> ids);
    public Task<T> Get(int id);
    public Task<T> Add(T model);
    public IEnumerable<T> AddRange(IEnumerable<T> models);
}