using design_problems.Domain;

namespace design_problems.Robots;

public sealed class RobotFactory : IRobotFactory
{
    public IRobot Create(RobotType type, string name, Position initialPosition)
    {
        return type switch
        {
            RobotType.Explorer => new ExplorerRobot(name, initialPosition),
            RobotType.Builder => new BuilderRobot(name, initialPosition),
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };
    }
}
