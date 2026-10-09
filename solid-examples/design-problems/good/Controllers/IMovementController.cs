using design_problems.Domain;
using design_problems.Robots;

namespace design_problems.Controllers;

public interface IMovementController
{
    Position Move(IRobot robot, Direction direction);
}
