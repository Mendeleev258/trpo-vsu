using design_problems.Domain;
using design_problems.Robots;

namespace design_problems.Controllers;

public sealed class MovementController : IMovementController
{
    public Position Move(IRobot robot, Direction direction)
    {
        ArgumentNullException.ThrowIfNull(robot);

        robot.Move(direction);
        return robot.Position;
    }
}
