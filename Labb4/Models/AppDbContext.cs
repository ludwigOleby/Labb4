using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb4.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Interests> Interests { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Websites> websites { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            // Seed interests
            modelBuilder.Entity<Interests>().HasData(new Interests { interestID = 1, interestName = "C#", details = "The fine art of making console applications", PersonID = 1 });
            modelBuilder.Entity<Interests>().HasData(new Interests { interestID = 2, interestName = "SQL", details = "Identifying and managing problems in a relationship", PersonID = 2});
            modelBuilder.Entity<Interests>().HasData(new Interests { interestID = 3, interestName = "Exterminator", details = "Eliminates various bugs", PersonID = 3 });
            modelBuilder.Entity<Interests>().HasData(new Interests { interestID = 4, interestName = "Overwatch", details = "Getting matched with bad teammates and loose games", PersonID = 1 });


            // Seed person
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 1, firstName = "Ludwig", lastName = "Oleby", phoneNr = "0736004656"  });
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 2, firstName = "Sara", lastName = "Sarasson", phoneNr = "0736004657" });
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 3, firstName = "Sam", lastName = "Samson", phoneNr = "0736004658" });

            // Seed Websites
            modelBuilder.Entity<Websites>().HasData(new Websites { WebpageID = 1, Webpage = "www.csharp.com", PersonID = 1, InterestID = 1 });
            modelBuilder.Entity<Websites>().HasData(new Websites { WebpageID = 2, Webpage = "www.playoverwatch.com", PersonID = 1, InterestID = 2 });
            modelBuilder.Entity<Websites>().HasData(new Websites { WebpageID = 3, Webpage = "www.sql.se", PersonID = 2, InterestID = 3 });
            modelBuilder.Entity<Websites>().HasData(new Websites { WebpageID = 4, Webpage = "www.bugs.com", PersonID = 3, InterestID = 4 });

        }
    }
}
