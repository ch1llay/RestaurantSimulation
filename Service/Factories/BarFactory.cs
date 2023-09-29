using Common.Enums;
using Service.DI.Interfaces;
using Service.Performers.Barmans;
using Service.Performers.Interfaces;
using Service.Workplaces;
using Service.Workplaces.Interfaces;

namespace Service.Factories;

public class BarFactory : PerformerContextFactory
{
    public override Performer GetPerformer()
    {
        return new BarmanMaster();
    }

    public override async Task<WorkPlace> GetWorkPlace(IServiceManager serviceManager)
    {
        var employee = await serviceManager.EmployeeDbService.GetByType(EmployeeType.Barman);

        return new Bar(employee.FirstOrDefault());
    }
}