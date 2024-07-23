using Microsoft.EntityFrameworkCore;
using CaesarCipher.Repository;

public class CipherContext : DbContext{


    // Allows exteran code to be passed in the configurations 
    public CipherContext(DbContextOptions<CipherContext> options) : base(options)
    {
    }

    public DbSet<Cipher> Ciphers { get; set; }
}