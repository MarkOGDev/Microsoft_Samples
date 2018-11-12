using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;

namespace MarkOGDev.Microsoft.Samples.ApplicationCore.Interfaces
{
  public   class Country
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=blogging.db");
        }
    }
}
