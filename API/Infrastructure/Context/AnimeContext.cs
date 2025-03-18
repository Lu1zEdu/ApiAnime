using API.Domain.Entity;
using API.Domain.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Infrastructure.Context;

public class AnimeContext : DbContext
{
    public AnimeContext(DbContextOptions<AnimeContext> options) : base(options) { }
    
    public DbSet<Adaptation> Adaptations { get; set; }
    public DbSet<Aired>  Aireds { get; set; }
    public DbSet<Anime> Animes { get; set; }
    public DbSet<Characters> Characters { get; set; }
    public DbSet<GenreAnime>  GenreAnimes { get; set; }
    public DbSet<Premiered> Premiereds { get; set; }
    public DbSet<Producer> Producers { get; set; }
    public DbSet<Ranked>  Rankeds { get; set; }
    public DbSet<Score> Scores { get; set; }
    public DbSet<Staff> Staffs { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AnimeContext).Assembly);
    }
}