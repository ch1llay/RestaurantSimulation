using Dapper;
using DataAccess.Interfaces;
using Microsoft.Extensions.Configuration;

namespace DataAccess;

public class DapperContext : IDataContext
{
    private readonly DbFactory.ConnectionMethod _connectionMethod;

    public DapperContext(IConfiguration config)
    {
        _connectionMethod = DbFactory.GetConnectionMethod(config);
    }

    public async Task<T> InsertAsync<T>(string script, object param)
    {
        await using var db = _connectionMethod();

        return await db.QueryFirstOrDefaultAsync<T>(script, param);
    }

    public async Task<IEnumerable<T>> InsertManyAsync<T>(string script, object param)
    {
        await using var db = _connectionMethod();

        return await db.QueryAsync<T>(script, param);
    }

    public async Task<T> FirstOrDefaultAsync<T>(string script, object param)
    {
        await using var db = _connectionMethod();

        return await db.QueryFirstOrDefaultAsync<T>(script, param);
    }

    public async Task<IEnumerable<T>> EnumerableOrEmptyAsync<T>(string script, object param)
    {
        await using var db = _connectionMethod();

        return await db.QueryAsync<T>(script, param);
    }

    public async Task<bool> DeleteAsync(string script, object param)
    {
        await using var db = _connectionMethod();

        return await db.ExecuteAsync(script, param) > 0;
    }

    public async Task<long> DeleteManyAsync(string script, object param)
    {
        await using var db = _connectionMethod();

        return await db.ExecuteAsync(script, param);
    }

    public async Task<T> UpdateAsync<T>(string script, object param)
    {
        await using var db = _connectionMethod();

        return await db.QueryFirstOrDefaultAsync<T>(script, param);
    }

    public async Task<IEnumerable<T>> UpdateManyAsync<T>(string script, object param)
    {
        await using var db = _connectionMethod();

        return await db.QueryAsync<T>(script, param);
    }
}