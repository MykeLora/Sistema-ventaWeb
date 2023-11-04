


using Microsoft.EntityFrameworkCore;
using SalesOnline.Infraestructure.Context;
using SalesOnline.Infraestructure.Interfaces;
using SalesOnline.Infraestructure.Repositories;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

// Agregar dependencia del contexto //
builder.Services.AddDbContext<SalesContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SalesContext")));

// Dependencia de los repositorios //

builder.Services.AddTransient<IUsuarioRepository, UsuarioRepository>();



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
