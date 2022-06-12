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
            radnici.ToList().ForEach(i => i.Adresa = shortString(i.Adresa,15));
            return View(radnici);
        }

        

        private String shortString(String input, int length)
        {
            if (input.Length > length)
            {
                input = input.Substring(0, length) + "...";
            }
            return input;
        }
    }
}
