using API.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace API.Infrastructure.Context;

public class ScoreContext : DbContext
{
    public ScoreContext(DbContextOptions<ScoreContext> options) : base(options)
    {
    }

    public DbSet<Score> Scores { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Anime> Animes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Score>()
            .HasKey(s => s.IdScore);

        modelBuilder.Entity<Score>()
            .HasOne<User>()
            .WithMany()
            .HasForeignKey(s => s.IdUser);

        modelBuilder.Entity<Score>()
            .HasOne<Anime>()
            .WithMany()
            .HasForeignKey(s => s.IdAnime);
    }
}