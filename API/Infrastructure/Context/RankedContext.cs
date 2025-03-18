using API.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace API.Infrastructure.Context;

public class RankedContext : DbContext
{
    // Construtor corrigido
    public RankedContext(DbContextOptions<RankedContext> options) : base(options) { }

    // Defina DbSets e mapeamentos
    public DbSet<Ranked> Rankeds { get; set; }
}