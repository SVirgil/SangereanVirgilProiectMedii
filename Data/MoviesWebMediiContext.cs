using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesWebMedii.Models;

namespace MoviesWebMedii.Data
{
    public class MoviesWebMediiContext : DbContext
    {
        public MoviesWebMediiContext(DbContextOptions<MoviesWebMediiContext> options)
            : base(options)
        {
        }

        public DbSet<MoviesWebMedii.Models.Movie> Movie { get; set; }

        public DbSet<MoviesWebMedii.Models.Studio> Studio { get; set; }

        public DbSet<MoviesWebMedii.Models.Category> Category { get; set; }
    }
}
