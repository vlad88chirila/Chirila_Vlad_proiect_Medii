using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Chirila_Vlad_proiect_Medii.Data;
using Chirila_Vlad_proiect_Medii.Models;

namespace Chirila_Vlad_proiect_Medii.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        private readonly Chirila_Vlad_proiect_Medii.Data.Chirila_Vlad_proiect_MediiContext _context;

        public DeleteModel(Chirila_Vlad_proiect_Medii.Data.Chirila_Vlad_proiect_MediiContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);

            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Category.FindAsync(id);

            if (Category != null)
            {
                _context.Category.Remove(Category);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
