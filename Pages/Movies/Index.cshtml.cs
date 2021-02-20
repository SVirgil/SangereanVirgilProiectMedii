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
    public class IndexModel : PageModel
    {
        private readonly MoviesWebMedii.Data.MoviesWebMediiContext _context;

        public IndexModel(MoviesWebMedii.Data.MoviesWebMediiContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
