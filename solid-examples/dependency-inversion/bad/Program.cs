using Bad.Models;
using Bad.Services;

Console.WriteLine("Медицинский центр \"Здоровье\"");

var appointmentService = new AppointmentService();
var appointment = new Appointment(
    "Анна Смирнова",
    "терапевт Иванова Е. В.",
    new DateTime(2026, 10, 12, 10, 30, 0));

appointmentService.Schedule(appointment);
