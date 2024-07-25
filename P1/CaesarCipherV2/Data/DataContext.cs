using Microsoft.EntityFrameworkCore;
using Models;

public class DataContext : DbContext{


    // Allows exteran code to be passed in the configurations 
    public CipherContext(DbContextOptions<CipherContext> options) : base(options)
    {
    }

    public DbSet<Cipher> Ciphers { get; set; }
}