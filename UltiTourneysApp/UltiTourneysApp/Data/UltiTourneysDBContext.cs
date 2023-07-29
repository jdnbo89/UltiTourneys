using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UltiTourneysApp.Models;

namespace UltiTourneysApp.Data
{
    public class UltiTourneysDBContext : DbContext
    {
        public UltiTourneysDBContext (DbContextOptions<UltiTourneysDBContext> options)
            : base(options)
        {
        }

        public DbSet<UltiTourneysApp.Models.Tournament> Tournament { get; set; } = default!;

        public DbSet<UltiTourneysApp.Models.Team> Team { get; set; } = default!;

        public DbSet<UltiTourneysApp.Models.Player> Player { get; set; } = default!;

        public DbSet<UltiTourneysApp.Models.Game> Game { get; set; } = default!;
    }
}