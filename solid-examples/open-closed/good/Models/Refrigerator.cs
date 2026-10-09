using Good.Interfaces;

namespace Good.Models;

public class Refrigerator(string name, double powerConsumption) : IAppliance
{
    public string Name { get; } = name;
    public double PowerConsumption { get; } = powerConsumption;

    public void Start() => Console.WriteLine($"{Name}: охлаждение запущено");
}
