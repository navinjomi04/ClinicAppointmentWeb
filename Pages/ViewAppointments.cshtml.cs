using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using ClinicAppointmentWeb.Models;

public class ViewAppointmentsModel : PageModel
{
    public List<Appointment> AppointmentsList => FakeDatabase.Appointments;

    public void OnGet() { }
}
