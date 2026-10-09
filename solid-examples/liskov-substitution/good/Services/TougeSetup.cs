using Good.Interfaces;

namespace Good.Services;

public static class TougeSetup
{
    // Любую реализацию интерфейса можно безопасно использовать без проверки
    // конкретного класса и без неожиданного исключения.
    public static string Prepare(IAllWheelDriveCar car) =>
        car.ConfigureTorqueDistribution(frontPercent: 35);
}
