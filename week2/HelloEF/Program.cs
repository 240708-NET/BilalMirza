using System;
using Microsoft.EntityFrameworkCore;

namespace HelloEF
{
    class Program
    {
        public static void Main ( string[] args)
        {
            Console.WriteLine("Hello Again!");

            Pet MyPet = new Pet {Name = "Sil", Cuteness = 9, Chaos = 100, Species = "Cat"};
            Console.WriteLine(MyPet.Speak());

            // DataContext?
            string ConnectionString = File.ReadAllText("./connectionstring"); // Connection string should have no spaces

            DbContextOptionsBuilder<DataContext> ContextOptions = new DbContextOptionsBuilder<DataContext>().UseSqlServer(ConnectionString);

            DataContext Context = new DataContext(ContextOptions.Options);
        }
    }

    class Pet
    {
        // Fields
        public int Id {get; set;}
        public string Name {get; set;}
        public int Cuteness {get; set;}
        public long Chaos {get; set;}
        public string Species {get; set;}

        // Constructors


        //Methods
        public string Speak()
        {
            return $"Hello, I'm {this.Name}!";
        }

    }

    class DataContext : DbContext // EntityFramework namespace
    {
        // Fields
        public DbSet<Pet> Pets => Set<Pet> ();

        // Constructors
        public DataContext (DbContextOptions<DataContext> options) : base(options) {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){}
    }


}