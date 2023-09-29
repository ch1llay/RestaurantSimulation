namespace Service.Services.Interfaces;

public interface IDbService<T, TT>
{
    public Task<T> Add(T dishT);
    public Task<IEnumerable<T>> GetAll();
    public Task<IEnumerable<T>> GetByType(TT type);
}