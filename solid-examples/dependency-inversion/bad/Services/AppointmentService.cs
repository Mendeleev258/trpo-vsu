using Bad.Models;

namespace Bad.Services;

// Нарушение DIP: высокоуровневый сервис напрямую зависит от конкретного
// способа отправки уведомлений и сам создаёт его.
public class AppointmentService
{
    private readonly SmsAppointmentNotifier _notifier = new();

    public void Schedule(Appointment appointment)
    {
        Console.WriteLine(
            $"Пациент {appointment.PatientName} записан к врачу: {appointment.DoctorName}");
        _notifier.SendConfirmation(appointment);
    }
}
