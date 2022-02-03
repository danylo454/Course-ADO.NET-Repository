using Microsoft.EntityFrameworkCore;
using Olympiad.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympiad.Data.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-PFI6MSV\SQLEXPRESS;Database=Course_Olympiada;Integrated Security=True");
            }
        }
        protected override void OnModelCreating(ModelBuilder model)
        {
            //Forenkey for class CountryAgent - idPlayerAgent
            model.Entity<CountryAgent>()
                .HasOne(p => p.Players)
                .WithMany(c => c.Agents)
                .HasForeignKey(p => p.IdPlayerAgent);

            model.Entity<OlympiadaTable>()
                .HasOne(t => t.CountryAgent)
                .WithMany(c => c.Olympiada)
                .HasForeignKey(t => t.IdCountryAgent);

            model.Entity<Olympiada>()
                .HasOne(t => t.OlympiadaTable)
                .WithMany(o => o.Olympiads)
                .HasForeignKey(t => t.IdTableOlypida);
        }
        public DbSet<CountryAgent> CountryAgents { get; set; }
        public DbSet<Olympiada> Olympiads { get; set;}
        public DbSet<OlympiadaTable> OlympiadaTables { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
