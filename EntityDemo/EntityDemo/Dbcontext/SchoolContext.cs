using EntityDemo.data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDemo.Dbcontext
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer (@"Server=Ayyapa\SQLEXPRESS;Database=student;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;");
        }
    }
}
