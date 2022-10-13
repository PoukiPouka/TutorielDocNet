using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TutorielDocNet.Pages.Models;

namespace TutorielDocNet.Data
{
    public class TutorielDocNetContext : DbContext
    {
        public TutorielDocNetContext (DbContextOptions<TutorielDocNetContext> options)
            : base(options)
        {
        }

        public DbSet<TutorielDocNet.Pages.Models.Movie> Movie { get; set; } = default!;
    }
}
