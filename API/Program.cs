
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Configuração do Entity Framework com PostgreSQL
//builder.Services.AddDbContext<DbPostgresql>(options =>options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = builder.Configuration["Swagger:Title"] ?? "Anime API",
        Description = "Um projeto simples de uma API sobre anime em C#",
        Version = "1.0.0.0",
        Contact = new OpenApiContact
        {
            Name = "Luiz Eduardo Da Silva Pinto",
            Email = "le6269199@gmail.com"
        }
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    // Adiciona o Swagger
    app.UseSwagger();

    // Adiciona a interface do Swagger UI
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Ecommerce API v1");
        c.RoutePrefix = string.Empty; // Acessível diretamente na raiz
    });
}

app.UseAuthorization();
app.MapControllers();
app.Run();