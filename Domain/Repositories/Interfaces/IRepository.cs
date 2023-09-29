namespace Domain.Repositories.Interfaces;

public interface IRepository<T, TT>
{
    public Task<IEnumerable<T>> GetAll();
    public Task<T> Add(T model);
    public Task<IEnumerable<T>> GetByType(TT type);
}