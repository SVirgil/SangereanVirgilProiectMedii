using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SangereanVirgilProiectMedii.Models;

namespace SangereanVirgilProiectMedii.Data
{
    public class SangereanVirgilProiectMediiContext : DbContext
    {
        public SangereanVirgilProiectMediiContext (DbContextOptions<SangereanVirgilProiectMediiContext> options)
            : base(options)
        {
        }

        public DbSet<SangereanVirgilProiectMedii.Models.Film> Film { get; set; }

    }
}
