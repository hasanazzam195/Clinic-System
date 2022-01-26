using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using clinicSystem.Models;
using clinicSystem.data;
namespace clinicSystem.Controllers
{
    public class CountryController : Controller
    {
        public IActionResult Index()
        {
            VMCountry vm = new VMCountry();
            List<Country> x = new List<Country>();
            vm.licountry = x;
            return View("country",vm); 
        }

        public IActionResult SearchDate()
        {
            ClinicContext context = new ClinicContext();
            VMCountry c = new VMCountry();
            string name = Request.Form["TxtSearchCountry"];
            List<Country> x = (from coun in context.country
                                       where coun.Name == name
                                       select coun).ToList();
            c.licountry = x;
            return View("country",c);
        }

        public IActionResult SaveData(VMCountry vM)
        {
            ClinicContext context = new ClinicContext();
            context.country.Add(vM.country);
            context.SaveChanges();
            List<Country> x =new List<Country>();
            vM.licountry = x;

            return View("country",vM);
        }
    }
}
