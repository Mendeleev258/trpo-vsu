using Good.Interfaces;

namespace Good.Models;

public class MazdaRx7 : IDrivable, IDriftable
{
    public void Drive() => Console.WriteLine("Mazda RX-7 едет по горному перевалу.");

    public void Drift() => Console.WriteLine("Mazda RX-7 проходит поворот в дрифте.");
}
