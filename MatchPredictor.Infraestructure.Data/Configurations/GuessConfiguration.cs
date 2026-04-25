using MatchPredictor.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MatchPredictor.Infraestructure.Data.Configurations
{
    public class GuessConfiguration : IEntityTypeConfiguration<Guess>
    {
        public void Configure(EntityTypeBuilder<Guess> entity)
        {
            entity.ToTable("Guesses");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.RegisteredAt)
                .IsRequired();

            entity.Property(e => e.PointsEarned)
                .IsRequired();

            entity.Property(e => e.IsCalculated)
                .IsRequired();

            entity.HasOne(e => e.PoolParticipant)
                .WithMany(pp => pp.Guesses)
                .HasForeignKey(e => e.PoolParticipantId);

            entity.HasOne(e => e.Match)
                .WithMany(m => m.Guesses)
                .HasForeignKey(e => e.MatchId);
        }
    }
}