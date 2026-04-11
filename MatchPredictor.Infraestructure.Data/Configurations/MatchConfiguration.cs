using MatchPredictor.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MatchPredictor.Infraestructure.Data.Configurations
{
    public class MatchConfiguration : IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> entity)
        {
            entity.ToTable("Matches");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Stadium)
                .HasMaxLength(200);

            entity.Property(e => e.City)
                .HasMaxLength(100);

            entity.Property(e => e.Status)
                .IsRequired();

            entity.Property(e => e.Phase)
                .IsRequired();

            entity.Property(e => e.Group)
                .HasMaxLength(10);

            entity.HasOne(e => e.HomeTeam)
                .WithMany(t => t.HomeMatches)
                .HasForeignKey(e => e.HomeTeamId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(e => e.AwayTeam)
                .WithMany(t => t.AwayMatches)
                .HasForeignKey(e => e.AwayTeamId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasMany(e => e.Guesses)
                .WithOne(g => g.Match)
                .HasForeignKey(g => g.MatchId);
        }
    }
}