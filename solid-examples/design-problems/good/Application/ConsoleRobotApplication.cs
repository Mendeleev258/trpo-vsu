using design_problems.Controllers;
using design_problems.Domain;
using design_problems.Robots;

namespace design_problems.Application;

public sealed class ConsoleRobotApplication
{
    private readonly IRobotFactory _robotFactory;
    private readonly IMovementController _movementController;
    private readonly IConstructionController _constructionController;

    public ConsoleRobotApplication(
        IRobotFactory robotFactory,
        IMovementController movementController,
        IConstructionController constructionController)
    {
        _robotFactory = robotFactory;
        _movementController = movementController;
        _constructionController = constructionController;
    }

    public void Run()
    {
        Console.WriteLine("=== Управление роботом (правильный дизайн) ===");

        RobotType robotType = ReadRobotType();
        string robotName = ReadRobotName();
        IRobot robot = _robotFactory.Create(robotType, robotName, new Position(0, 0));

        Console.WriteLine();
        Console.WriteLine($"Робот \"{robot.Name}\" создан в точке {robot.Position}.");

        RunCommandLoop(robot);
    }

    private void RunCommandLoop(IRobot robot)
    {
        while (true)
        {
            PrintActionMenu(robot);
            Console.Write("Ваш выбор: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Move(robot, Direction.Up, "вверх");
                    break;
                case "2":
                    Move(robot, Direction.Down, "вниз");
                    break;
                case "3":
                    Move(robot, Direction.Right, "вправо");
                    break;
                case "4":
                    Move(robot, Direction.Left, "влево");
                    break;
                case "5" when robot is IBuildingRobot builder:
                    Build(builder);
                    break;
                case "0":
                    Console.WriteLine(
                        $"Робот \"{robot.Name}\" завершил работу в точке {robot.Position}.");
                    return;
                default:
                    Console.WriteLine("Ошибка: такого действия нет.");
                    break;
            }
        }
    }

    private void Move(IRobot robot, Direction direction, string directionName)
    {
        Position position = _movementController.Move(robot, direction);
        Console.WriteLine($"Робот переместился {directionName}. Координаты: {position}.");
    }

    private void Build(IBuildingRobot robot)
    {
        Building building = _constructionController.Build(robot);
        Console.WriteLine($"Построена {building.Name} в точке {building.Position}.");
    }

    private static RobotType ReadRobotType()
    {
        while (true)
        {
            Console.WriteLine("Выберите тип робота:");
            Console.WriteLine("1 — исследователь (шаг 3)");
            Console.WriteLine("2 — строитель (шаг 1)");
            Console.Write("Ваш выбор: ");

            switch (Console.ReadLine())
            {
                case "1":
                    return RobotType.Explorer;
                case "2":
                    return RobotType.Builder;
                default:
                    Console.WriteLine("Ошибка: выберите пункт 1 или 2.");
                    continue;
            }
        }
    }

    private static string ReadRobotName()
    {
        while (true)
        {
            Console.Write("Введите имя робота: ");
            string? name = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(name))
            {
                return name.Trim();
            }

            Console.WriteLine("Ошибка: имя робота не может быть пустым.");
        }
    }

    private static void PrintActionMenu(IRobot robot)
    {
        Console.WriteLine();
        Console.WriteLine("Выберите действие:");
        Console.WriteLine("1 — двигаться вверх");
        Console.WriteLine("2 — двигаться вниз");
        Console.WriteLine("3 — двигаться вправо");
        Console.WriteLine("4 — двигаться влево");

        if (robot is IBuildingRobot)
        {
            Console.WriteLine("5 — построить башню");
        }

        Console.WriteLine("0 — завершить работу");
    }
}
