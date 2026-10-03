using Microsoft.EntityFrameworkCore;
using KartingMigrations.Models;

namespace KartingMigrations.Data
{
    public class KartingContext : DbContext
    {
        public KartingContext(DbContextOptions<KartingContext> options)
            :base(options)
        {
        }
        public DbSet<Pilote> Pilotes { get; set; }
    }
}
