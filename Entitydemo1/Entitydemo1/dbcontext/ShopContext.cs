using Entitydemo1.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitydemo1.dbcontext
{
    public class ShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=Ayyapa\SQLEXPRESS;Database=shop;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;");
        }



    }
}
