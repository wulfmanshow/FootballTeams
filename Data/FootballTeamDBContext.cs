using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Data
{
    public class FootballTeamDBContext : DbContext
    {
        public DbSet<FootballTeam> Teams { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { 
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-H61STOF;Database=TeamsLibrary;Trusted_Connection=True;TrustServerCertificate=True;");
        }

    }
}
