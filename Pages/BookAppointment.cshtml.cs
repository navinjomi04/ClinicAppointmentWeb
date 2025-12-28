using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using ClinicAppointmentWeb.Models;

public class BookAppointmentModel : PageModel
{
    [BindProperty]
    public string SelectedPatient { get; set; }

    [BindProperty]
    public DateTime AppointmentDate { get; set; }

    public string Message { get; set; }

    public List<Patient> Patients => FakeDatabase.Patients;

    public void OnGet() { }

    public void OnPost()
    {
        if (!string.IsNullOrEmpty(SelectedPatient))
        {
            FakeDatabase.Appointments.Add(new Appointment
            {
                PatientName = SelectedPatient,
                Date = AppointmentDate.ToShortDateString()
            });
            Message = "Appointment booked successfully!";
        }
        else
        {
            Message = "Please select a patient.";
        }
    }
}
