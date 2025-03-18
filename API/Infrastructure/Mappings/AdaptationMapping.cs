using API.Domain.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Infrastructure.Mappings;

public class AdaptationMapping : IEntityTypeConfiguration<Adaptation>
{
    public void Configure(EntityTypeBuilder<Adaptation> builder)
    {
        builder.ToTable("Adaptations");

        builder.HasKey(a => a.IdAdaptation);

        builder.Property(a => a.NameWork)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(a => a.TypeWork)
            .IsRequired();
    }
}