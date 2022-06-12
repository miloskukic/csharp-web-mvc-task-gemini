using csharp_web_mvc_task_gemini.Data;
using csharp_web_mvc_task_gemini.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_web_mvc_task_gemini.Controllers
{
    public class RadniciController : Controller
    {
        private readonly AppDbContext db;
        public RadniciController(AppDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index(Radnik radnik)
        {
            IEnumerable<Radnik> radnici = db.Radnici;
            return View(radnici);
        }

        

        private double perctangeToValue(double number, double perctange)
        {
            if (perctange > 100)
            {
                perctange = perctange * 0.0001;
                Console.WriteLine("PERC100>" + perctange);
                number = number * perctange;
            }
            else if (perctange > 10)
            {
                perctange = perctange * 0.001;
                Console.WriteLine("PERC10>" + perctange);
                number = number * perctange;
            }
            else
            {
                Console.WriteLine("PERC0>" + perctange);
                number = number * perctange/100;
            }
            return number;
        }
    }
}
