using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using ClinicAppointmentWeb.Models;

public class AddPatientModel : PageModel
{
    [BindProperty]
    public string PatientName { get; set; }

    [BindProperty]
    public int PatientAge { get; set; }

    public string Message { get; set; }

    public List<Patient> Patients => FakeDatabase.Patients;

    public void OnGet() { }

    public void OnPost()
    {
        if (!string.IsNullOrEmpty(PatientName))
        {
            FakeDatabase.Patients.Add(new Patient
            {
                Name = PatientName,
                Age = PatientAge
            });
            Message = "Patient added successfully!";
        }
    }
}
