using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SangereanVirgilProiectMedii.Data;
using SangereanVirgilProiectMedii.Models;

namespace SangereanVirgilProiectMedii.Pages.Categorii
{
    public class DeleteModel : PageModel
    {
        private readonly SangereanVirgilProiectMedii.Data.SangereanVirgilProiectMediiContext _context;

        public DeleteModel(SangereanVirgilProiectMedii.Data.SangereanVirgilProiectMediiContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CategorieFilm CategorieFilm { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CategorieFilm = await _context.CategorieFilm
                .Include(c => c.Categorie)
                .Include(c => c.Film).FirstOrDefaultAsync(m => m.ID == id);

            if (CategorieFilm == null)
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

            CategorieFilm = await _context.CategorieFilm.FindAsync(id);

            if (CategorieFilm != null)
            {
                _context.CategorieFilm.Remove(CategorieFilm);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
