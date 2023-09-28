using Models.Application;
using Models.Enums;
using Service.Performers;
using Service.Performers.Interfaces;
using Service.Preparing;
using Service.Preparing.Interfaces;

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