using design_problems.Domain;

namespace design_problems.Robots;

public abstract class Robot : IRobot
{
    protected Robot(string name, Position initialPosition, double movementStep)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Имя робота не может быть пустым.", nameof(name));
        }

        if (movementStep <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(movementStep),
                "Длина шага должна быть больше нуля.");
        }

        Name = name;
        Position = initialPosition;
        MovementStep = movementStep;
    }

    public string Name { get; }
    public Position Position { get; private set; }
    public double MovementStep { get; }

    public void Move(Direction direction)
    {
        Position = Position.Move(direction, MovementStep);
    }
}
