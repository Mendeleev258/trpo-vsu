using Bad.Models;

namespace Bad.Services;

public static class TougeSetup
{
    // Метод ожидает рабочий полный привод от любого переданного подтипа,
    // но ToyotaSupraA80 нарушает это ожидание.
    public static string Prepare(AllWheelDriveJdmCar car) =>
        car.ConfigureTorqueDistribution(frontPercent: 35);
}
