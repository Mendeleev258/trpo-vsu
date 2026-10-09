using Bad.Models;
using Bad.Services;

var cars = new AllWheelDriveJdmCar[]
{
    new NissanSkylineGtrR34(),
    new ToyotaSupraA80()
};

foreach (var car in cars)
{
    Console.WriteLine($"{car.Model}: {car.Drive()}");

    try
    {
        Console.WriteLine(TougeSetup.Prepare(car));
    }
    catch (InvalidOperationException exception)
    {
        Console.WriteLine(exception.Message);
    }
}
