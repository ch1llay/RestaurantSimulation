using Dapper;
using DataAccess.Interfaces;

namespace DataAccess;

public class DapperContext : IDataContext
{
    private readonly DbFactory.ConnectionMethod _connectionMethod;

    public DapperContext(DbFactory.ConnectionMethod connectionMethod)
    {
        _connectionMethod = connectionMethod;
    }

    public async Task<T> Insert<T>(string script, object param)
    {
        await using var db = _connectionMethod();

        return await db.QueryFirstOrDefaultAsync<T>(script, param);
    }

    public async Task<IEnumerable<T>> InsertMany<T>(string script, object param)
    {
        await using var db = _connectionMethod();

        return await db.QueryAsync<T>(script, param);
    }

    public async Task<T> FirstOrDefault<T>(string script, object param)
    {
        await using var db = _connectionMethod();

        return await db.QueryFirstOrDefaultAsync<T>(script, param);
    }

    public async Task<IEnumerable<T>> EnumerableOrEmpty<T>(string script, object param)
    {
        await using var db = _connectionMethod();

        return await db.QueryAsync<T>(script, param);
    }

    public async Task<bool> Delete(string script, object param)
    {
        await using var db = _connectionMethod();

        return await db.ExecuteAsync(script, param) > 0;
    }

    public async Task<long> DeleteMany(string script, object param)
    {
        await using var db = _connectionMethod();

        return await db.ExecuteAsync(script, param);
    }

    public async Task<T> Update<T>(string script, object param)
    {
        await using var db = _connectionMethod();

        return await db.QueryFirstOrDefaultAsync<T>(script, param);
    }

    public async Task<IEnumerable<T>> UpdateMany<T>(string script, object param)
    {
        await using var db = _connectionMethod();

        return await db.QueryAsync<T>(script, param);
    }
}