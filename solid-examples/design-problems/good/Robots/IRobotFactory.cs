using design_problems.Domain;

namespace design_problems.Robots;

public interface IRobotFactory
{
    IRobot Create(RobotType type, string name, Position initialPosition);
}
