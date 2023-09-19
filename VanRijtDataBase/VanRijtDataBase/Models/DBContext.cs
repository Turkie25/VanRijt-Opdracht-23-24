using Microsoft.EntityFrameworkCore;

namespace VanRijtDataBase.Models
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
        : base(options)
        {

        }

        public DbSet<Login> Login { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Evenement> Evenement { get; set; }
        public DbSet<Adres> Adres { get; set; }
        public DbSet<EvenementData> EvenementData { get; set; }

        public DbSet<EvenementVeranderingen> EvenementVeranderingen { get; set; }
    }
}

