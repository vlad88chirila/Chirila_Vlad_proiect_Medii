using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Chirila_Vlad_proiect_Medii.Models;

namespace Chirila_Vlad_proiect_Medii.Data
{
    public class Chirila_Vlad_proiect_MediiContext : DbContext
    {
        public Chirila_Vlad_proiect_MediiContext (DbContextOptions<Chirila_Vlad_proiect_MediiContext> options)
            : base(options)
        {
        }

        public DbSet<Chirila_Vlad_proiect_Medii.Models.Movie> Movie { get; set; }

        public DbSet<Chirila_Vlad_proiect_Medii.Models.Producer> Producer { get; set; }

        public DbSet<Chirila_Vlad_proiect_Medii.Models.Category> Category { get; set; }
    }
}
