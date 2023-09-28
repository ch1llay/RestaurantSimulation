using DataAccess.Interfaces;

namespace DataAccess.DI.Interfaces;

public interface IDataContextManager
{
    public IDataContext DataContext { get; }
}