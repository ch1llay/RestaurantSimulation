using Service.DI.Interfaces;
using Service.Performers.Interfaces;
using Service.Workplaces.Interfaces;

namespace Service.Factories;

public abstract class PerformerContextFactory
{
    public abstract Performer GetPerformer();
    public abstract Task<WorkPlace> GetWorkPlace(IServiceManager serviceManager);
}