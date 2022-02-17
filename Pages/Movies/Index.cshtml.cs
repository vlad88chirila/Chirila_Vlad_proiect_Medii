using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Chirila_Vlad_proiect_Medii.Data;
using Chirila_Vlad_proiect_Medii.Models;

namespace Chirila_Vlad_proiect_Medii.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Chirila_Vlad_proiect_Medii.Data.Chirila_Vlad_proiect_MediiContext _context;

        public IndexModel(Chirila_Vlad_proiect_Medii.Data.Chirila_Vlad_proiect_MediiContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.Include(b => b.Producer).ToListAsync();
        }
    }
}
