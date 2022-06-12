using csharp_web_mvc_task_gemini.Data;
using csharp_web_mvc_task_gemini.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_web_mvc_task_gemini.Controllers
{
    public class RadnikController : Controller
    {
        private readonly AppDbContext db;
        public RadnikController(AppDbContext db)
        {
            this.db = db;
        }

  

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Id(int? id)
        {
            Radnik radnik = db.Radnici.Find(id);
            //radnik.Ime = "Test";
            return View(radnik);
        }

        public IActionResult Dodaj()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Dodaj(Radnik radnik)
        {
            double osnovica = double.Parse(Request.Form["osnovica-field"]);
            double porez = double.Parse(Request.Form["porez-field"]);

            radnik.PIO = (radnik.NetoPlata * radnik.PIO) / 100;
            radnik.Zdravstveno = (radnik.NetoPlata * radnik.Zdravstveno) / 100;
            radnik.Nezaposlenost = (radnik.NetoPlata * radnik.Nezaposlenost) / 100;
            radnik.PIOPoslodavac = (radnik.NetoPlata * radnik.PIOPoslodavac) / 100;
            radnik.ZdravstvenoPoslodavac = (radnik.NetoPlata * radnik.ZdravstvenoPoslodavac / 100);
            radnik.NezaposlenostPoslodavac = (radnik.NetoPlata * radnik.NezaposlenostPoslodavac) / 100;
            radnik.BrutoPlata = radnik.NetoPlata + radnik.PIO + radnik.Zdravstveno + radnik.Nezaposlenost + (float)(osnovica * porez / 100);
            radnik.UkupniTroskovi = radnik.BrutoPlata + radnik.PIOPoslodavac + radnik.ZdravstvenoPoslodavac + radnik.NezaposlenostPoslodavac;

            Console.WriteLine("OSNOVICA>" + osnovica);
            Console.WriteLine("POREZ>" + porez);
            // Console.WriteLine("Radnik>" + radnik.Ime + " " + radnik.Prezime + " " + radnik.Adresa + " " + radnik.NetoPlata + " PIO>"+radnik.PIO) ;
            db.Add(radnik);
            db.SaveChanges();
            //Console.WriteLine("NEW-USER-ID>"+radnik.Id);
            return RedirectToAction("Id","Radnik",new { Id = radnik.Id });
        }
    }
}
