using API.Domain.Entity;
using Microsoft.EntityFrameworkCore;
namespace API.Infrastructure.Context;
public class CharactersContext : DbContext
{
    public CharactersContext(DbContextOptions<CharactersContext> options) : base(options) { }

    // DbSet para a tabela de personagens
    public DbSet<Characters> Characters { get; set; }

    // Se você precisar de mais tabelas associadas aos personagens, pode adicionar outras DbSets aqui

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CharactersContext).Assembly);
    }
}

