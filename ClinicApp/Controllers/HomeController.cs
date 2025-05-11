using ClinicApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        List<Doctor> doctors = new List<Doctor>();
        Doctor doctor1 = new Doctor
        {
            Id = 1,
            ImgUrl = "team-1.jpg",
            DoctorName = "Nazrin Alifova",
            Department = "Kadiolog"
        };
        Doctor doctor2 = new Doctor
        {
            Id = 1,
            ImgUrl = "team-4.jpg",
            DoctorName = "Osman Mammadli",
            Department = "Nevrolog"
        };
        Doctor doctor3 = new Doctor
        {
            Id = 1,
            ImgUrl = "team-3.jpg",
            DoctorName = "Aysel Mustafayeva",
            Department = "Estetk Cerrah"
        };
        Doctor doctor4 = new Doctor
        {
            Id = 1,
            ImgUrl = "team-2.jpg",
            DoctorName = "Shukran Suleymanli",
            Department = "Avtomotolog"
        };

        doctors.Add(doctor1);
        doctors.Add(doctor2);
        doctors.Add(doctor3);
        doctors.Add(doctor4);



        return View(doctors);
    }
}
