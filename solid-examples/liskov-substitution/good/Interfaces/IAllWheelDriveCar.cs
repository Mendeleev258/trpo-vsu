namespace Good.Interfaces;

// Этот контракт реализуют только автомобили, которые действительно
// поддерживают распределение момента между осями.
public interface IAllWheelDriveCar : IJdmCar
{
    string ConfigureTorqueDistribution(int frontPercent);
}
