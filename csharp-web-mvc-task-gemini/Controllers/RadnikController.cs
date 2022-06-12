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
            return RedirectToAction("Index","Radnici");
        }

        public IActionResult Id(int? id)
        {
            if(id!=null && id != 0)
            {
                if (db.Radnici.Contains(db.Radnici.Find(id)))
                {
                    Radnik radnik = db.Radnici.Find(id);
                    return View(radnik);
                }
            }
            return RedirectToAction("Index","Radnici");
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
            
            db.Add(radnik);
            db.SaveChanges();
            return RedirectToAction("Id","Radnik",new { Id = radnik.Id });
        }

        public IActionResult Izmeni(int? id)
        {
            if (id != null && id != 0)
            {
                if (db.Radnici.Contains(db.Radnici.Find(id)))
                {
                    Radnik radnik = db.Radnici.Find(id);
                    return View(radnik);
                }
            }
            return RedirectToAction("Index", "Radnici");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Izmeni(Radnik radnik)
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

           db.Radnici.Update(radnik);
           db.SaveChanges();
           return RedirectToAction("Index", "Radnici");
        }

        public IActionResult Obrisi(int? id)
        {
            if (id != null && id != 0)
            {
                if (db.Radnici.Contains(db.Radnici.Find(id)))
                {
                    db.Radnici.Remove(db.Radnici.Find(id));
                    db.SaveChanges();
                    return RedirectToAction("Index", "Radnici");
                }
            }
            return RedirectToAction("Index", "Radnici");
        }
    }
}
