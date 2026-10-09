using Good.Interfaces;

namespace Good.Services;

public class ApplianceManager
{
    private readonly List<IAppliance> _appliances = [];

    public void Add(IAppliance appliance) => _appliances.Add(appliance);

    public double CalculateTotalEnergyConsumption() =>
        _appliances.Sum(appliance => appliance.PowerConsumption);

    public void StartAll()
    {
        foreach (IAppliance appliance in _appliances)
        {
            appliance.Start();
        }
    }
}
