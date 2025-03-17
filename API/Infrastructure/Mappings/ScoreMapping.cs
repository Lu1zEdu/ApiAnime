using API.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Infrastructure.Mappings;

public class ScoreMapping : IEntityTypeConfiguration<Score>
{
    public void Configure(EntityTypeBuilder<Score> builder)
    {
        builder.ToTable("Score");

        builder.HasKey("IdScore");
        
        builder.Property(x => x.IdScore)
            .HasColumnName("IdScore")
            .HasColumnType("Guid")
            .IsRequired();
        
        
    }
}