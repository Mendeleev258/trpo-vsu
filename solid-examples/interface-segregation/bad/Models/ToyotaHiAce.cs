using Bad.Interfaces;

namespace Bad.Models;

public class ToyotaHiAce : IJdmCar
{
    public void Drive() => Console.WriteLine("Toyota HiAce едет по улицам Токио.");

    public void Drift() =>
        throw new NotSupportedException("Toyota HiAce не предназначен для дрифта.");

    public void LoadCargo() => Console.WriteLine("В Toyota HiAce загружены запчасти из Японии.");
}
