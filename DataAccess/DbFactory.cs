using System.Data.Common;
using System.Data.SqlClient;
using DataAccess.Interfaces;
using Npgsql;

namespace DataAccess;

public class DbFactory
{
    public delegate DbConnection ConnectionMethod();

    public static IDataContext GetDataContextType(DbProvider provider, string connectionString)
    {
        switch (provider)
        {
            case DbProvider.Mssql:
                return new DapperContext(() =>
                {
                    var con = new SqlConnection(connectionString);
                    con.Open();

                    return con;
                });

            case DbProvider.Pgsql:
                return new DapperContext(() =>
                {
                    var con = new NpgsqlConnection(connectionString);
                    con.Open();

                    return con;
                });

            case DbProvider.Mongo:
                return new MongoContext(connectionString);

            default:
                throw new NotImplementedException();
        }
    }
}