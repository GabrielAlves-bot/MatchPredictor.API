using MatchPredictor.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MatchPredictor.Infraestructure.Data.Configurations
{
    public class PoolParticipantConfiguration : IEntityTypeConfiguration<PoolParticipant>
    {
        public void Configure(EntityTypeBuilder<PoolParticipant> entity)
        {
            entity.ToTable("PoolParticipants");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.EntryDate)
                .IsRequired();

            entity.Property(e => e.Score)
                .IsRequired();

            entity.HasOne(e => e.Pool)
                .WithMany(p => p.Participants)
                .HasForeignKey(e => e.PoolId);

            entity.HasOne(e => e.User)
                .WithMany(u => u.PoolParticipants)
                .HasForeignKey(e => e.UserId);

            entity.HasMany(e => e.Guesses)
                .WithOne(g => g.PoolParticipant)
                .HasForeignKey(g => g.PoolParticipantId);
        }
    }
}