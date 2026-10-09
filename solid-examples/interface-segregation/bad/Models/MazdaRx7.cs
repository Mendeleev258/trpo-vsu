using Bad.Interfaces;

namespace Bad.Models;

public class MazdaRx7 : IJdmCar
{
    public void Drive() => Console.WriteLine("Mazda RX-7 едет по горному перевалу.");

    public void Drift() => Console.WriteLine("Mazda RX-7 проходит поворот в дрифте.");

    public void LoadCargo() =>
        throw new NotSupportedException("В Mazda RX-7 нельзя перевозить крупный груз.");
}
