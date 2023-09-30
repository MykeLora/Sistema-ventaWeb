
using Microsoft.EntityFrameworkCore;
using SalesOnline.Domain.Entities;

namespace SalesOnline.Infraestructure.Context
{
    public class MenuContext : DbContext
    {

        public DbSet<Menu> Menu { get; set; }
        public DbSet<MenuRol> MenuRol { get; set; }
    }
}
