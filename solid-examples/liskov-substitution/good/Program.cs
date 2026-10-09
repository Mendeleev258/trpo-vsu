using Good.Interfaces;
using Good.Models;
using Good.Services;

var cars = new IJdmCar[]
{
    new NissanSkylineGtrR34(),
    new ToyotaSupraA80()
};

foreach (var car in cars)
{
    Console.WriteLine($"{car.Model}: {car.Drive()}");

    Console.WriteLine(car is IAllWheelDriveCar allWheelDriveCar
        ? TougeSetup.Prepare(allWheelDriveCar)
        : "распределение момента недоступно для заднего привода");
}
