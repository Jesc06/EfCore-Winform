using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfCore.Model;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace EfCore.Services.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Students> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost;Database=studentInfo;User=root;Password=0624";
            optionsBuilder.UseMySql(connectionString,ServerVersion.AutoDetect(connectionString));
        }
    }
}
