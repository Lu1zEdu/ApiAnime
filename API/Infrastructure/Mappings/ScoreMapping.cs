using API.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Infrastructure.Mappings;

public class ScoreMapping : IEntityTypeConfiguration<Score>
{
    public void Configure(EntityTypeBuilder<Score> builder)
    {
        builder.ToTable("Score");

        builder.HasKey(s => s.IdScore);

        builder.Property(s => s.IdScore)
            .HasColumnName("IdScore")
            .IsRequired();
    }
}