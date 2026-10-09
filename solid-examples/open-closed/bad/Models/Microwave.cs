namespace Bad.Models;

public class Microwave(string name, double powerConsumption)
{
    public string Name { get; } = name;
    public double PowerConsumption { get; } = powerConsumption;

    public void Heat() => Console.WriteLine($"{Name}: разогрев запущен");
}
