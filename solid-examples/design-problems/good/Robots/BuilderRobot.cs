using design_problems.Domain;

namespace design_problems.Robots;

public sealed class BuilderRobot : Robot, IBuildingRobot
{
    private const double BuilderMovementStep = 1.0;

    public BuilderRobot(string name, Position initialPosition)
        : base(name, initialPosition, BuilderMovementStep)
    {
    }

    public Building Build() => new("башня", Position);
}
