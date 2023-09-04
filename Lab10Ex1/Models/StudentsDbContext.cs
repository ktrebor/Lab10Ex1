using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Ex1.Models
{
    internal class StudentsDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public StudentsDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rober\source\repos\Lab10Ex1\Lab10Ex1\MyStudentsDb.mdf;Integrated Security=True");
        }
    }
}
