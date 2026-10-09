using Good.Interfaces;
using Good.Models;

namespace Good.Services;

public class SmsAppointmentNotifier : IAppointmentNotifier
{
    public void SendConfirmation(Appointment appointment)
    {
        Console.WriteLine(
            $"SMS для пациента {appointment.PatientName}: приём подтверждён на " +
            $"{appointment.StartsAt:dd.MM.yyyy в HH:mm}");
    }
}
