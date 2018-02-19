using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHowest;

namespace Lesvoorbeeld2MVC.Controllers
{
    public class HomeController : Controller
    {
        private string[] groenten = { "Rode kool", "Spruitjes", "Wortel", "SpiNazi", "Aardappellleen", "Apple" , "Pear", "ComaPatient"};
        public ViewResult Index(string name)
        {
            ViewBag.Groet = DateTime.Now.Hour < 12 ? "Goeiemorgen" : "Goeie-Niet-Morgen";
            return View();
        }

        public ViewResult Groenten(string zoekGroente)
        {
            ViewBag.Groenten = groenten;
            if (!string.IsNullOrEmpty(zoekGroente))
            {
                ViewBag.Zoekresultaat = $"De gezochte groente is de {Array.IndexOf(groenten, zoekGroente) + 1}e uit de lijst";
            }
            
            return View();
        }

        public ViewResult Student()
        {
            List<Student> studenten = new List<Student>
            {
                new Student { Id=23, Naam="Stefke", AfstudeerGraad=Graad.Voldoening},
                new Student { Id = 23, Naam = "Tomke", AfstudeerGraad = Graad.Onderscheiding }
            };
            ViewBag.Studenten = studenten;
            return View();
        }
    }
}