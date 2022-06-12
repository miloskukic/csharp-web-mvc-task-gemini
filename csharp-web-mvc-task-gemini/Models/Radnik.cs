using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_web_mvc_task_gemini.Models
{
    public class Radnik
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Ime { get; set; }
        [Required]
        public String Prezime { get; set; }
        [Required]
        public String Adresa { get; set; }
        [Required]
        public double NetoPlata { get; set; }
        public double BrutoPlata { get; set; }
        public double PIO { get; set; }
        public double Zdravstveno { get; set; }
        public double Nezaposlenost { get; set; }
        public double PIOPoslodavac { get; set; }
        public double ZdravstvenoPoslodavac { get; set; }
        public double NezaposlenostPoslodavac { get; set; }
        public double UkupniTroskovi { get; set; }
    }
    

}
