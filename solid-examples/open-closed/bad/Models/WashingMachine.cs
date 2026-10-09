namespace Bad.Models;

public class WashingMachine(string name, double powerConsumption)
{
    public string Name { get; } = name;
    public double PowerConsumption { get; } = powerConsumption;

    public void Wash() => Console.WriteLine($"{Name}: стирка запущена");
}
