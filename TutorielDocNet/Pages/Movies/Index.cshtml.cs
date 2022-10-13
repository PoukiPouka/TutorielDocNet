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
    public class IndexModel : PageModel
    {
        private readonly TutorielDocNet.Data.TutorielDocNetContext _context;

        public IndexModel(TutorielDocNet.Data.TutorielDocNetContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
