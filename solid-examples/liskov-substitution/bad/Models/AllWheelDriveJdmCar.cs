namespace Bad.Models;

// Базовый класс обещает, что для любого его наследника можно настроить полный привод.
public abstract class AllWheelDriveJdmCar
{
    public abstract string Model { get; }
    public abstract string Drive();

    public virtual string ConfigureTorqueDistribution(int frontPercent)
    {
        var rearPercent = 100 - frontPercent;
        return $"распределение момента — {frontPercent}% на переднюю ось, {rearPercent}% на заднюю";
    }
}
