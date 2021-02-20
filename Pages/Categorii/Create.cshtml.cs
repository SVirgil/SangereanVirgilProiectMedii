using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SangereanVirgilProiectMedii.Data;
using SangereanVirgilProiectMedii.Models;

namespace SangereanVirgilProiectMedii.Pages.Categorii
{
    public class CreateModel : PageModel
    {
        private readonly SangereanVirgilProiectMedii.Data.SangereanVirgilProiectMediiContext _context;

        public CreateModel(SangereanVirgilProiectMedii.Data.SangereanVirgilProiectMediiContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CategorieID"] = new SelectList(_context.Set<Categorie>(), "ID", "ID");
        ViewData["FilmID"] = new SelectList(_context.Film, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public CategorieFilm CategorieFilm { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CategorieFilm.Add(CategorieFilm);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
