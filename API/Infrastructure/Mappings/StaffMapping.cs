using API.Domain.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Infrastructure.Mapping;

public class StaffMapping : IEntityTypeConfiguration<Staff>
{
    public void Configure(EntityTypeBuilder<Staff> builder)
    {
        builder.ToTable("Staff");
        
        builder.HasKey("IdStaff");
        
        builder.Property(x => x.IdStaff)
            .HasColumnName("StaffId");
        
        builder.Property(x => x.NameEStaff)
            .HasColumnName("NameEStaff")
            .IsRequired()
            .HasMaxLength(250);
        
        builder.Property(x => x.GivenNameJ)
            .HasColumnName("GivenNameJ")
            .IsRequired()
            .HasMaxLength(250);
        
        builder.Property(x => x.FamilyNameJ)
            .HasColumnName("FamilyNameJ")
            .IsRequired()
            .HasMaxLength(250);
        
        builder.Property(x => x.Website)
            .HasMaxLength(250);
        
        builder.Property(x => x.BirthdayStaff)
            .HasColumnType("date")
            .HasColumnName("BirthdayStaff")
            .IsRequired();
    }
}