
using Microsoft.EntityFrameworkCore;
using SalesOnline.Domain.Entities;

namespace SalesOnline.Infraestructure.Context
{
    public class SalesContext : DbContext 
    {
        public SalesContext(DbContextOptions<SalesContext> options) : base(options) { 
        }

        public DbSet<Category> Categorys { get; set; }
    }
}
