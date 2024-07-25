using Microsoft.EntityFrameworkCore;
using Models;

namespace Repository
{
    public class CipherContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = File.ReadAllText("../connectionString");
            optionsBuilder.UseSqlServer(connectionString);
        }

        // public CipherContext(DbContextOptions<CipherContext> options) : base(options)
        // {
        // }

        public DbSet<Cipher> Ciphers { get; set; }
    }
}