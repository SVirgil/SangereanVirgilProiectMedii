using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesWebMedii.Data;
using MoviesWebMedii.Models;

namespace MoviesWebMedii.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly MoviesWebMedii.Data.MoviesWebMediiContext _context;

        public DetailsModel(MoviesWebMedii.Data.MoviesWebMediiContext context)
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
