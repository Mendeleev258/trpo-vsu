using design_problems.Domain;

namespace design_problems.Robots;

public interface IBuildingRobot : IRobot
{
    Building Build();
}
