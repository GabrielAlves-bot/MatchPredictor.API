using MatchPredictor.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MatchPredictor.Infraestructure.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Championship> Championships { get; set; }
        public DbSet<Pool> Pools { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PoolParticipant> PoolParticipants { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Guess> Guesses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}