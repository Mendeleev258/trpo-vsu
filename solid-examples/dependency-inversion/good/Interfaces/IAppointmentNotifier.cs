using Good.Models;

namespace Good.Interfaces;

public interface IAppointmentNotifier
{
    void SendConfirmation(Appointment appointment);
}
