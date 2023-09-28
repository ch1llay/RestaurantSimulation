namespace Service.Services.Interfaces;

public interface ICrudService<T, TT>
{
    public Task<T> Add(T dishT);
    Task<List<T>> AddMany(List<T> dishes);
    public Task<IEnumerable<T>> GetAll();
    public Task<IEnumerable<T>> GetByIds(IEnumerable<int> orderTIds);
    public Task<IEnumerable<T>> GetAllAvailable();
    public Task<IEnumerable<T>> GetByType(TT type);
    Task<List<T?>> GetByTypeAvailable(TT dishType);
    Task<T?> Update(T dish);
    Task<bool?> Delete(int id);
}