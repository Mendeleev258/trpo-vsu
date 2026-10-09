using Good.Interfaces;

namespace Good.Models;

// Supra остается полноценным JDM-автомобилем, но не притворяется полноприводным.
public sealed class ToyotaSupraA80 : IJdmCar
{
    public string Model => "Toyota Supra A80";
    public string Drive() => "задний привод";
}
