using design_problems.Domain;

namespace design_problems.Robots;

public interface IRobot
{
    string Name { get; }
    Position Position { get; }
    double MovementStep { get; }

    void Move(Direction direction);
}
