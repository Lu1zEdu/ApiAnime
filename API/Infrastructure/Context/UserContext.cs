using API.Domain.Entity;
using API.Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;

namespace API.Infrastructure.Context;

public class UserContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public UserContext(DbContextOptions<UserContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserMapping()); 
        base.OnModelCreating(modelBuilder);
    }
}