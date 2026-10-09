namespace bad;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("=== Управление роботом (плохой дизайн) ===");
        Console.WriteLine("Выберите тип робота:");
        Console.WriteLine("1 — исследователь (шаг 3)");
        Console.WriteLine("2 — строитель (шаг 1)");

        string type;
        double step;

        while (true)
        {
            Console.Write("Ваш выбор: ");
            string? robotChoice = Console.ReadLine();

            if (robotChoice == "1")
            {
                type = "explorer";
                step = 3.0;
                break;
            }

            if (robotChoice == "2")
            {
                type = "builder";
                step = 1.0;
                break;
            }
            Console.WriteLine("Ошибка: выберите пункт 1 или 2.");
        }

        Console.Write("Введите имя робота: ");
        string name = Console.ReadLine() ?? string.Empty;

        if (string.IsNullOrWhiteSpace(name))
        {
            name = "Безымянный робот";
        }

        double x = 0;
        double y = 0;
        Robot robot = new Robot(name, type, x, y, step);

        Console.WriteLine();
        Console.WriteLine($"Робот \"{name}\" типа \"{type}\" создан в точке ({x}, {y}).");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 — двигаться вверх");
            Console.WriteLine("2 — двигаться вниз");
            Console.WriteLine("3 — двигаться вправо");
            Console.WriteLine("4 — двигаться влево");

            if (type == "builder")
            {
                Console.WriteLine("5 — построить башню");
            }

            Console.WriteLine("0 — завершить работу");
            Console.Write("Ваш выбор: ");

            string? action = Console.ReadLine();

            switch (action)
            {
                case "1":
                    robot.Move("up");
                    y += step;
                    Console.WriteLine($"Робот переместился вверх. Координаты: ({x}, {y}).");
                    break;
                case "2":
                    robot.Move("down");
                    y -= step;
                    Console.WriteLine($"Робот переместился вниз. Координаты: ({x}, {y}).");
                    break;
                case "3":
                    robot.Move("right");
                    x += step;
                    Console.WriteLine($"Робот переместился вправо. Координаты: ({x}, {y}).");
                    break;
                case "4":
                    robot.Move("left");
                    x -= step;
                    Console.WriteLine($"Робот переместился влево. Координаты: ({x}, {y}).");
                    break;
                case "5" when type == "builder":
                    robot.Build();
                    break;
                case "0":
                    Console.WriteLine($"Робот \"{name}\" завершил работу в точке ({x}, {y}).");
                    return;
                default:
                    Console.WriteLine("Ошибка: такого действия нет.");
                    break;
            }
        }
    }
}
