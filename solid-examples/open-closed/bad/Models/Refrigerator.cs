namespace Bad.Models;

public class Refrigerator(string name, double powerConsumption)
{
    public string Name { get; } = name;
    public double PowerConsumption { get; } = powerConsumption;

    public void Cool() => Console.WriteLine($"{Name}: охлаждение запущено");
}
