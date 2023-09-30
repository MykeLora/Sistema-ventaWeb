
using Microsoft.EntityFrameworkCore;
using SalesOnline.Domain.Entities;
using System.Data.Common;

namespace SalesOnline.Infraestructure.Context
{
    public class SalesContext : DbContext 
    {
        public SalesContext(DbContextOptions<SalesContext> options) : base(options) { 
        }

        public DbSet<Category> Categorys { get; set; }

        public DbSet<DetalleVenta> detalleVentas { get; set; }

       public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuRol> menuRols { get; set; }
        public DbSet<NumeroDocumento> numeroDocuments { get; set; }
        public DbSet<Producto> productos { get; set; }
        public DbSet<Rol> rol { get; set; }
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Venta> ventas { get; set; }
    }
}
