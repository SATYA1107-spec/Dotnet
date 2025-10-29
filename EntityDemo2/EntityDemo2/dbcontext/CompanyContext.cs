using EntityDemo2.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDemo2.dbcontext
{
    public class CompanyContext:DbContext
    {
        public DbSet<Employe> Employes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=Ayyapa\SQLEXPRESS;Database=shop;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;");
        }
        
    }
}
