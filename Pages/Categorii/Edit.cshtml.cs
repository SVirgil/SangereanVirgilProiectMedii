using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SangereanVirgilProiectMedii.Data;
using SangereanVirgilProiectMedii.Models;

namespace SangereanVirgilProiectMedii.Pages.Categorii
{
    public class EditModel : PageModel
    {
        private readonly SangereanVirgilProiectMedii.Data.SangereanVirgilProiectMediiContext _context;

        public EditModel(SangereanVirgilProiectMedii.Data.SangereanVirgilProiectMediiContext context)
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
           ViewData["CategorieID"] = new SelectList(_context.Set<Categorie>(), "ID", "ID");
           ViewData["FilmID"] = new SelectList(_context.Film, "ID", "ID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CategorieFilm).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategorieFilmExists(CategorieFilm.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CategorieFilmExists(int id)
        {
            return _context.CategorieFilm.Any(e => e.ID == id);
        }
    }
}
