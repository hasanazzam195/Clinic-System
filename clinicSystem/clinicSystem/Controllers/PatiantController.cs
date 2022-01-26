using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using clinicSystem.Models;
using clinicSystem.data;

namespace clinicSystem.Controllers
{
    public class PatiantController : Controller
    {
        public IActionResult Index()
        {
            List<Patient> patients = new List<Patient>();
            return View("PatientList",patients);
        }

        public IActionResult NewPatiaent()
        {
            ClinicContext context = new ClinicContext();
            List<Country> a = (from cnt in context.country
                               select cnt).ToList();
            VMPatient vm = new VMPatient();
            vm.licountry = a;
            return View("NewPatiaent",vm);
        }

        public IActionResult SaveDate(VMPatient vM)
        {
            ClinicContext context = new ClinicContext();
            context.patients.Add(vM.patient);
            context.SaveChanges();
            List<Country> x = (from cnt in context.country
                               select cnt).ToList();
            vM.licountry = x;
            return View("NewPatiaent",vM);
        }

        public IActionResult SearchData()
        {
            ClinicContext context = new ClinicContext();
            string name = Request.Form["TxtSearch"];
            List<Patient> liPatient = (from pat in context.patients
                                       where pat.Name == name
                                       select pat).ToList();
            return View("PatientList", liPatient);
        }


    }
}
