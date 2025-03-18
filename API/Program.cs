using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using API.Infrastructure.Context;

var builder = WebApplication.CreateBuilder(args);

// Configuração dos Contextos com SQLite
builder.Services.AddDbContext<AnimeContext>(options =>
    options.UseSqlite("DataSource=Anime.db"));
builder.Services.AddDbContext<StaffContext>(options =>
    options.UseSqlite("DataSource=User.db")); // Arquivo diferente

// Configuração do Swagger e Controllers
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Anime API",
        Description = "API para gerenciamento de animes e personagens",
        Version = "1.0.0",
        Contact = new OpenApiContact
        {
            Name = "Luiz Eduardo",
            Email = "le6269199@gmail.com"
        }
    });
});

var app = builder.Build();

// Middlewares
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => 
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Anime API v1");
        c.RoutePrefix = string.Empty;
    });
}

app.UseAuthorization();
app.MapControllers();
app.Run();