using Good.Interfaces;

namespace Good.Models;

public class ToyotaHiAce : IDrivable, ICargoCarrier
{
    public void Drive() => Console.WriteLine("Toyota HiAce едет по улицам Токио.");

    public void LoadCargo() => Console.WriteLine("В Toyota HiAce загружены запчасти из Японии.");
}
