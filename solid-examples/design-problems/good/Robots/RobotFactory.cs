using design_problems.Domain;

namespace design_problems.Robots;

/*
    Вообще говоря, такая фабрика тоже отчасти нарушает Open-Closed,
    и можно было бы нарулить DI-контейнер, чтобы полностью вынести логику создания
    и подтягивания всего необходимого туда, но для такого приложения это overengineering
 */
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
