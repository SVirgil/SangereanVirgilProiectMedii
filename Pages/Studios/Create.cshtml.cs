using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MoviesWebMedii.Data;
using MoviesWebMedii.Models;

namespace MoviesWebMedii.Pages.Studios
{
    public class CreateModel : PageModel
    {
        private readonly MoviesWebMedii.Data.MoviesWebMediiContext _context;

        public CreateModel(MoviesWebMedii.Data.MoviesWebMediiContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Studio Studio { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Studio.Add(Studio);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
