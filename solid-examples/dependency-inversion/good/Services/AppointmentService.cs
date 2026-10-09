using Good.Interfaces;
using Good.Models;

namespace Good.Services;

// Соблюдение DIP: высокоуровневый сервис зависит от абстракции,
// а конкретный способ уведомления передаётся извне.
public class AppointmentService(IAppointmentNotifier notifier)
{
    public void Schedule(Appointment appointment)
    {
        Console.WriteLine(
            $"Пациент {appointment.PatientName} записан к врачу: {appointment.DoctorName}");
        notifier.SendConfirmation(appointment);
    }
}
