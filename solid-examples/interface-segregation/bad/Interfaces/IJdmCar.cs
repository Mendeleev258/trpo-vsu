namespace Bad.Interfaces;

// Нарушение ISP: интерфейс заставляет каждый автомобиль поддерживать
// даже те возможности, которые ему не нужны.
public interface IJdmCar
{
    void Drive();
    void Drift();
    void LoadCargo();
}
