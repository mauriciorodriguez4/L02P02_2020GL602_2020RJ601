using Microsoft.EntityFrameworkCore;

namespace L02P02_2020GL602_2020RJ601.Models
{
    public class restauranteDbContext : DbContext
    {
        public restauranteDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<pedidos> pedidos { get; set; }

        public DbSet<platos> platos { get; set; }

        public DbSet<motoristas> motoristas { get; set;}
        public DbSet<clientes> clientes { get; set;}
    }
}
