using MatchPredictor.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MatchPredictor.Infraestructure.Data.Configurations
{
    public class ChampionshipConfiguration : IEntityTypeConfiguration<Championship>
    {
        public void Configure(EntityTypeBuilder<Championship> entity)
        {
            entity.ToTable("Championships");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(150);

            entity.Property(e => e.Season)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.StartDate)
                .IsRequired();

            entity.Property(e => e.EndDate)
                .IsRequired();

            entity.HasMany(e => e.Pools)
                .WithOne(p => p.Championship)
                .HasForeignKey(p => p.ChampionshipId);
        }
    }
}
