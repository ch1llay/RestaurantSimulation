using DataAccess.DataContexts;
using DataAccess.DataContexts.Interfaces;
using DataAccess.DI.Interfaces;
using Microsoft.Extensions.Configuration;

namespace DataAccess.DI;

public class DataContextManager : IDataContextManager
{
    private readonly Lazy<IDataContext> _lazyDataContext;

    public DataContextManager(IConfiguration configuration)
    {
        _lazyDataContext = new Lazy<IDataContext>(() => new DapperContext(configuration));
    }


    public IDataContext DataContext => _lazyDataContext.Value;
}