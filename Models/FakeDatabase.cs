using System.Collections.Generic;

namespace ClinicAppointmentWeb.Models
{
    public static class FakeDatabase
    {
        public static List<Patient> Patients { get; set; } = new List<Patient>();
        public static List<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
