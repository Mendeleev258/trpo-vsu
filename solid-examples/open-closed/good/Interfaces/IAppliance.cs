namespace Good.Interfaces;

public interface IAppliance
{
    string Name { get; }
    double PowerConsumption { get; }
    void Start();
}
