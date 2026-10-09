using design_problems.Domain;
using design_problems.Robots;

namespace design_problems.Controllers;

public sealed class ConstructionController : IConstructionController
{
    public Building Build(IBuildingRobot robot)
    {
        ArgumentNullException.ThrowIfNull(robot);
        return robot.Build();
    }
}
