using DataAccess.Interfaces;
using MongoDB.Driver;

namespace DataAccess;

public class MongoContext : IDataContext
{
    private string _connectionString;
    private IMongoClient _mongoClient;

    public MongoContext(string connectionString)
    {
        _connectionString = connectionString;
    }

    public Task<T> Insert<T>(string script, object param)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<T>> InsertMany<T>(string script, object param)
    {
        throw new NotImplementedException();
    }

    public Task<T> FirstOrDefault<T>(string script, object param)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<T>> EnumerableOrEmpty<T>(string script, object param)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(string script, object param)
    {
        throw new NotImplementedException();
    }

    public Task<long> DeleteMany(string script, object param)
    {
        throw new NotImplementedException();
    }

    public Task<T> Update<T>(string script, object param)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<T>> UpdateMany<T>(string script, object param)
    {
        throw new NotImplementedException();
    }
}