using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using csharp_web_mvc_task_gemini.Models;

namespace csharp_web_mvc_task_gemini.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Radnik> Radnici { get; set; }
    }
}
