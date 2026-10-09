using Bad.Models;

namespace Bad.Services;

public class SmsAppointmentNotifier
{
    public void SendConfirmation(Appointment appointment)
    {
        Console.WriteLine(
            $"SMS для пациента {appointment.PatientName}: приём подтверждён на " +
            $"{appointment.StartsAt:dd.MM.yyyy в HH:mm}");
    }
}
