using Good.Interfaces;

namespace Good.Models;

public sealed class NissanSkylineGtrR34 : IAllWheelDriveCar
{
    public string Model => "Nissan Skyline GT-R R34";
    public string Drive() => "ATTESA E-TS, полный привод";

    public string ConfigureTorqueDistribution(int frontPercent)
    {
        var rearPercent = 100 - frontPercent;
        return $"распределение момента — {frontPercent}% на переднюю ось, {rearPercent}% на заднюю";
    }
}
