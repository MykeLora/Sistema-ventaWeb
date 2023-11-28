using Microsoft.EntityFrameworkCore;
using SalesOnline.Application.Contract;
using SalesOnline.Application.Service;
using SalesOnline.Infraestructure.Context;
using SalesOnline.Infraestructure.Interfaces;
using SalesOnline.Infraestructure.Repositories;

var builder = WebApplication.CreateBuilder(args);


// Agregar dependencia del contexto //
builder.Services.AddDbContext<SalesContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SalesContext")));




// Dependencia de los repositorios //
builder.Services.AddTransient<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddTransient<IUsuarioService, UsuarioService>();



// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
