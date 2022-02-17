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
    public class DetailsModel : PageModel
    {
        private readonly Chirila_Vlad_proiect_Medii.Data.Chirila_Vlad_proiect_MediiContext _context;

        public DetailsModel(Chirila_Vlad_proiect_Medii.Data.Chirila_Vlad_proiect_MediiContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
