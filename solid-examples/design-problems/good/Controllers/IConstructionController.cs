using design_problems.Domain;
using design_problems.Robots;

namespace design_problems.Controllers;

public interface IConstructionController
{
    Building Build(IBuildingRobot robot);
}
