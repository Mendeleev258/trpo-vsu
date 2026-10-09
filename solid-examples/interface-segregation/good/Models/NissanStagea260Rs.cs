using Good.Interfaces;

namespace Good.Models;

public class NissanStagea260Rs : IDrivable, IDriftable, ICargoCarrier
{
    public void Drive() => Console.WriteLine("Nissan Stagea 260RS выезжает из JDM-гаража.");

    public void Drift() => Console.WriteLine("Nissan Stagea 260RS проходит поворот боком.");

    public void LoadCargo() => Console.WriteLine("В Nissan Stagea 260RS загружен комплект колёс.");
}
