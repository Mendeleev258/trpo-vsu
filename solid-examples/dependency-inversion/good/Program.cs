using Good.Models;
using Good.Services;

Console.WriteLine("Медицинский центр \"Здоровье\"");

var notifier = new SmsAppointmentNotifier();
var appointmentService = new AppointmentService(notifier);
var appointment = new Appointment(
    "Анна Смирнова",
    "терапевт Иванова Е. В.",
    new DateTime(2026, 10, 12, 10, 30, 0));

appointmentService.Schedule(appointment);
