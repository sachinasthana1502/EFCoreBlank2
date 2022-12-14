using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class AppDbContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }



        // Database Connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=DESKTOP-8K1TFI1;Initial Catalog=EfDB12dec;Integrated Security=True;TrustServerCertificate=True");
            }

            
        }

    }
}
