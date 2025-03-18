using API.Domain.Entity;
using API.Domain.DTO;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Infrastructure.Mapping;
    
public class AnimeMapping : IEntityTypeConfiguration<Anime>
{
    public void Configure(EntityTypeBuilder<Anime> builder)
    {
        builder.ToTable("Animes");

        builder.HasKey(a => a.IdAnime);

        builder.Property(a => a.NameJapanese)
            .IsRequired()
            .HasMaxLength(200);
        
        builder.Property(a => a.NameEnglish)
            .HasMaxLength(200);
        
        builder.Property(a => a.NamePortugues)
            .HasMaxLength(200);
        
        builder.Property(a => a.Synopsis)
            .HasColumnType("TEXT");
        
        builder.Property(a => a.Synonyms)
            .HasMaxLength(500);
        
        builder.Property(a => a.Episodes)
            .IsRequired();
        
        builder.Property(a => a.DurationEps)
            .IsRequired();
        
        builder.Property(a => a.Popularity)
            .IsRequired();

        builder.Property(a => a.DateStar)
            .IsRequired();
        
        builder.Property(a => a.DateEnd)
            .IsRequired();

        builder.HasOne(a => a.Adaptation)
            .WithMany()
            .HasForeignKey("AdaptationId");

        builder.HasOne(a => a.Premiered)
            .WithMany()
            .HasForeignKey("PremieredId");

        builder.HasOne(a => a.Aired)
            .WithMany()
            .HasForeignKey("AiredId");

        builder.Property(a => a.Demographic)
            .IsRequired();
        
        builder.Property(a => a.Rating)
            .IsRequired();
        
        builder.Property(a => a.Licensors)
            .IsRequired();
        
        builder.Property(a => a.Status)
            .IsRequired();

        builder.Property(a => a.Themes)
            .IsRequired();
        
        builder.Property(a => a.Source)
            .IsRequired();
        
        builder.Property(a => a.TypeDisplay)
            .IsRequired();
        
    }
}
