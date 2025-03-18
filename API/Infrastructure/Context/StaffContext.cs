using API.Domain.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Infrastructure.Context;

public class StaffContext : DbContext
{
    // Construtor obrigatório para configuração via AddDbContext
    public StaffContext(DbContextOptions<StaffContext> options) : base(options) { }

    public DbSet<Staff> Staff { get; set; }

    // Adicione configurações de mapeamento se necessário
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(StaffContext).Assembly);
    }
}