using API.Domain.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Infrastructure.Context;

public class StaffContext :  DbContext
{
    public DbSet<Staff> Staff { get; set; }
}