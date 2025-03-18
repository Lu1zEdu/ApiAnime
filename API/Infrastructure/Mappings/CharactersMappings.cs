using API.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Infrastructure.Mappings;

public class CharactersMapping : IEntityTypeConfiguration<Characters>
{
    public void Configure(EntityTypeBuilder<Characters> builder)
    {
        builder.ToTable("Characters");

        builder.HasKey(c => c.IdCharacters);

        builder.Property(c => c.NameCharactersE)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(c => c.NameCharactersJ)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(c => c.UrlImage)
            .HasMaxLength(300);

        builder.Property(c => c.DescribeCharacters)
            .HasColumnType("TEXT");

        builder.Property(c => c.BirthdateCharacters)
            .IsRequired();

        builder.Property(c => c.Height)
            .IsRequired();
        
        builder.Property(c => c.Weight)
            .IsRequired();
        
        builder.Property(c => c.PositionCharacters)
            .IsRequired();
        
    }
}