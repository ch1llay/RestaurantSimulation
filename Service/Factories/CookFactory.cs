using Common.Enums;
using Service.DI.Interfaces;
using Service.Models;
using Service.Performers.Cooks;
using Service.Performers.Interfaces;
using Service.Workplaces;
using Service.Workplaces.Interfaces;

namespace Service.Factories;

public class CookFactory : PerformerContextFactory
{
    public override Performer GetPerformer()
    {
        return new CookMaster();
    }

    public override async Task<WorkPlace> GetWorkPlace(IServiceManager serviceManager)
    {
        var employee = await serviceManager.EmployeeDbService.GetByType(EmployeeType.Cook);

        return new Kitchen(employee.FirstOrDefault());
    }
}