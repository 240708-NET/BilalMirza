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
            //string ConnectionString = File.ReadAllText("./connectionstring"); // Connection string should have no spaces
            // DbContextOptionsBuilder<DataContext> ContextOptions = new DbContextOptionsBuilder<DataContext>().UseSqlServer(ConnectionString);
            // DataContext Context = new DataContext(ContextOptions.Options);
        }
        public static Pet GetPet( Pet MyPet)
        {
            using (var context = new DataContext())
            {
                List<Pet> petList = context.PetsDB.ToList();

                // LINQ
                // Language Integrated Query
                // we need an enumerable of things/objects to search through, and we can query against that enumerable.

                foreach (var p in petList)
                {
                    Console.WriteLine(p.id + " " + p.Name);
                }
            }
            return new Pet();
        }

        public static Pet GetPetById( int id)
        {
            using (var context = new DataContext())
            {
                Pet pet = context.PetsDB.Find(id);
                return pet;
            }
            return new Pet();
        }

        public static CreatePet (Pet newPet)
        {
            using ( var context = new DataContext())
            {
                context.Add(MyPet); // we introduce the object to the context
                context.SaveChanges();
            }
            return GetPet(newPet);
        }
    

        class Pet
        {
            // Fields
            public int Id {get; set;}
            public string? Name {get; set;}
            public int? Cuteness {get; set;}
            public long? Chaos {get; set;}
            public string? Species {get; set;}

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
            public DbSet<Pet> PetsDB => Set<Pet> ();

            // Constructors
            // public DataContext (DbContextOptions<DataContext> options) : base(options) {}

            string ConnectionString = File.ReadAllText("./connectionstring"); // Connection string should have no spaces

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }
    }
}