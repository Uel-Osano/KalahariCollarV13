using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KalahariCollarV13.Models;

namespace KalahariCollarV13.Data
{
    public class KalahariCollarV13Context : DbContext
    {
        public KalahariCollarV13Context (DbContextOptions<KalahariCollarV13Context> options)
            : base(options)
        {
        }

        public DbSet<KalahariCollarV13.Models.Pet> Pet { get; set; } = default!;
    }
}
