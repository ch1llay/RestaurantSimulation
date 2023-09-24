namespace DataAccess.Interfaces;

public interface IDataContext
{
    public Task<T> InsertAsync<T>(string script, object param);
    public Task<IEnumerable<T>> InsertManyAsync<T>(string script, object param);
    public Task<T> FirstOrDefaultAsync<T>(string script, object param);
    public Task<IEnumerable<T>> EnumerableOrEmptyAsync<T>(string script, object param);
    public Task<bool> DeleteAsync(string script, object param);
    public Task<long> DeleteManyAsync(string script, object param);
    public Task<T> UpdateAsync<T>(string script, object param);
    public Task<IEnumerable<T>> UpdateManyAsync<T>(string script, object param);
}