using API.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Infrastructure.Mapping;

public class UserMapping : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.HasKey("IdUser");
        
        builder.Property(x => x.IdUser)
            .HasColumnName("IdUser");
        
        builder.Property(x => x.FirstName)
            .HasColumnName("FirstName")
            .IsRequired()
            .HasMaxLength(50);
        
        builder.Property(x => x.LastName)
            .HasColumnName("LastName")
            .IsRequired()
            .HasMaxLength(150);
        
        builder.Property(x => x.Username)
            .HasColumnName("Username")
            .IsRequired()
            .HasMaxLength(50);
        
        builder.Property(x => x.Email)
            .HasColumnName("Email")
            .IsRequired()
            .HasMaxLength(50);
        
        builder.Property(x => x.Password)
            .HasColumnName("Password")
            .HasMaxLength(50)
            .IsRequired();
        
        builder.Property(u => u.Active)
            .IsRequired();
        
        builder.Property(x => x.BirthDate)
            .HasColumnName("BirthDate")
            .IsRequired();
        
        builder.Property(x => x.Rating)
            .HasColumnName("Rating")
            .IsRequired();
    }
}