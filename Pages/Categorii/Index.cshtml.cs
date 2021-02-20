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
    public class IndexModel : PageModel
    {
        private readonly SangereanVirgilProiectMedii.Data.SangereanVirgilProiectMediiContext _context;

        public IndexModel(SangereanVirgilProiectMedii.Data.SangereanVirgilProiectMediiContext context)
        {
            _context = context;
        }

        public IList<CategorieFilm> CategorieFilm { get;set; }

        public async Task OnGetAsync()
        {
            CategorieFilm = await _context.CategorieFilm
                .Include(c => c.Categorie)
                .Include(c => c.Film).ToListAsync();
        }
    }
}
