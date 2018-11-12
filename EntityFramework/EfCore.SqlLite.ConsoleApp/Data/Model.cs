using Microsoft.EntityFrameworkCore;

namespace MarkOGDev.Microsoft.Samples.EfCore.SqlLite.ConsoleApp.Data
{

    /// <summary>
    /// Entity Framework Model of our Data
    /// </summary>
    public class Model
    {
        public class BloggingContext : DbContext
        {
            //   public DbSet<Blog> Blogs { get; set; }
            //  public DbSet<Post> Posts { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite("Data Source=blogging.db");
            }
        }

        public class Directory
        {
            public int DirectoryId { get; set; }

            public string Name { get; set; }

            public string Description { get; set; }


        }

        public class Item
        {
            public int ItemId { get; set; }

            public string Title { get; set; }

            public string Description { get; set; }

            public string Image { get; set; }

        }

    }
}
