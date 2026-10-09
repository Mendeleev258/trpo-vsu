using design_problems.Domain;

namespace design_problems.Robots;

public sealed class ExplorerRobot : Robot
{
    private const double ExplorerMovementStep = 3.0;

    public ExplorerRobot(string name, Position initialPosition)
        : base(name, initialPosition, ExplorerMovementStep)
    {
    }
}
