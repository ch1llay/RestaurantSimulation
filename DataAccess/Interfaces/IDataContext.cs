namespace DataAccess.Interfaces;

public interface IDataContext
{
    public Task<T> Insert<T>(string script, object param);
    public Task<IEnumerable<T>> InsertMany<T>(string script, object param);
    public Task<T> FirstOrDefault<T>(string script, object param);
    public Task<IEnumerable<T>> EnumerableOrEmpty<T>(string script, object param);
    public Task<bool> Delete(string script, object param);
    public Task<long> DeleteMany(string script, object param);
    public Task<T> Update<T>(string script, object param);
    public Task<IEnumerable<T>> UpdateMany<T>(string script, object param);
}