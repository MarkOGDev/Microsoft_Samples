using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MarkOGDev.Microsoft_Samples.EfCoreSqlLite.ConsoleApp.Data
{
    //Code First Data Annotations
    //https://docs.microsoft.com/en-gb/ef/ef6/modeling/code-first/data-annotations

    /// <summary>
    /// Entity Framework Model of our Data. Normally you would use clean architecture with interfaces etc.
    /// </summary>
   
        public class DirectoriesContext : DbContext
        {
            public DbSet<Directory> Directories { get; set; }
            public DbSet<Item> Items { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite("Data Source=Directories.db");
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                //Set up Unique Field. Indexes can not be created using data annotations. You can use Fluent API like this:
                modelBuilder.Entity<Directory>()
                    .HasIndex(b => b.Name)
                    .IsUnique();



                //Seed some Data 
                modelBuilder.Entity<Directory>().HasData(
                        new Directory
                        {
                            DirectoryId = 1,
                            Name = "Exotic Cars Online",
                            Description = "Amazing Exotic Cars for sale"
                        },
                        new Directory
                        {
                            DirectoryId = 2,
                            Name = "Fashion Swap Shop UK",
                            Description = "Swap Not Buy."
                        }
                        );


                modelBuilder.Entity<Item>().HasData(
                        new Item { DirectoryId = 1, ItemId = 1, Title = "BMW I8" },
                        new Item { DirectoryId = 1, ItemId = 2, Title = "Porsche 911" },
                        new Item { DirectoryId = 1, ItemId = 3, Title = "Ferrari  Enzo" },
                        new Item { DirectoryId = 2, ItemId = 4, Title = "Classic Knee High Boots" },
                        new Item { DirectoryId = 2, ItemId = 5, Title = "Designer Handbag" },
                        new Item { DirectoryId = 2, ItemId = 6, Title = "Groovy Summer Hat" }
                        );



            }
        }

       
        public class Directory
        {
            [DatabaseGenerated(DatabaseGeneratedOption.None)]   //DatabaseGeneratedOption.None indicates that we are supplying the data ourselves and do not want an auto incremented ID.
            public int DirectoryId { get; set; }

            [Required]
            [MaxLength(30), MinLength(5)]
            public string Name { get; set; }

            [Required]
            public string Description { get; set; }

            //Relationships can be defined single(one way navigation) or Fully(two way navigation)
            //https://docs.microsoft.com/en-us/ef/core/modeling/relationships

            public ICollection<Item> Items { get; set; }
        }

        public class Item
        {
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            public int ItemId { get; set; }

            [Required]
            [MaxLength(30), MinLength(5)]
            public string Title { get; set; }


            public string Description { get; set; }


            public string Image { get; set; }


            public int DirectoryId { get; set; }
            public Directory Directory { get; set; }

        }

    }
 
