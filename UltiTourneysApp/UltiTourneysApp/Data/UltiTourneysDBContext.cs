using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UltiTourneysApp.Classes;

namespace UltiTourneysApp.Data
{
    public class UltiTourneysDBContext : DbContext
    {
        public UltiTourneysDBContext (DbContextOptions<UltiTourneysDBContext> options)
            : base(options)
        {
        }

        public DbSet<UltiTourneysApp.Classes.Tournament> Tournament { get; set; } = default!;

        public DbSet<UltiTourneysApp.Classes.Team> Team { get; set; } = default!;

        public DbSet<UltiTourneysApp.Classes.Player> Player { get; set; } = default!;

        public DbSet<UltiTourneysApp.Classes.Game> Game { get; set; } = default!;
    }
}