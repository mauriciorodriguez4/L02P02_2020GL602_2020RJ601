using Microsoft.EntityFrameworkCore;

namespace L02P02_2020GL602_2020RJ601.Models
{
    public class restauranteDbContext : DbContext
    {
        public restauranteDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
