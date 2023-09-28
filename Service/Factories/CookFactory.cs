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

    public override WorkPlace GetWorkPlace()
    {
        return new Kitchen();
    }
}