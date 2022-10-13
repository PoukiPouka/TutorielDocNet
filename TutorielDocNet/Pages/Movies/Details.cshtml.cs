using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TutorielDocNet.Data;
using TutorielDocNet.Pages.Models;

namespace TutorielDocNet.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly TutorielDocNet.Data.TutorielDocNetContext _context;

        public DetailsModel(TutorielDocNet.Data.TutorielDocNetContext context)
        {
            _context = context;
        }

      public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Movie == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);
            if (movie == null)
            {
                return NotFound();
            }
            else 
            {
                Movie = movie;
            }
            return Page();
        }
    }
}
