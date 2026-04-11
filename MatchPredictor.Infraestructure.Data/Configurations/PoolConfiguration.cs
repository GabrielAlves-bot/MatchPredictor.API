using MatchPredictor.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MatchPredictor.Infraestructure.Data.Configurations
{
    public class PoolConfiguration : IEntityTypeConfiguration<Pool>
    {
        public void Configure(EntityTypeBuilder<Pool> entity)
        {
            entity.ToTable("Pools");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(150);

            entity.Property(e => e.GuessDeadline)
                .IsRequired();

            entity.HasOne(e => e.Championship)
                .WithMany(c => c.Pools)
                .HasForeignKey(e => e.ChampionshipId);

            entity.HasMany(e => e.Participants)
                .WithOne(p => p.Pool)
                .HasForeignKey(p => p.PoolId);
        }
    }
}