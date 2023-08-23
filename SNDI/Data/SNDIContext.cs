using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SNDI.Models;

namespace SNDI.Data
{
    public class SNDIContext : DbContext
    {
        public SNDIContext (DbContextOptions<SNDIContext> options)
            : base(options)
        {
        }

        public DbSet<SNDI.Models.Document> Document { get; set; } = default!;

        public DbSet<SNDI.Models.Filiation>? Filiation { get; set; } = default!;
        public DbSet<SNDI.Models.Enregistrer>? Enregistrer { get; set; } = default!;
        public DbSet<SNDI.Models.DemandeInit>? DemandeInit { get; set; } = default!;
        
    }
}
