namespace Bad.Models;

// Нарушение LSP: Supra объявлена подтипом полноприводной машины, однако не может
// выполнить предусмотренную базовым классом операцию.
public sealed class ToyotaSupraA80 : AllWheelDriveJdmCar
{
    public override string Model => "Toyota Supra A80";
    public override string Drive() => "задний привод";

    public override string ConfigureTorqueDistribution(int frontPercent) =>
        throw new InvalidOperationException("распределение момента недоступно для заднего привода");
}
