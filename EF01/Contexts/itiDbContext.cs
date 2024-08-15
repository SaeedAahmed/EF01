using EF01.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Contexts
{
    internal class itiDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
             => optionsBuilder.UseSqlServer("Server = . ; Database = ItiP01 ; Trusted_Connection= true ; Encrypt=False");
       
        public DbSet<Student> Student { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Stud_Course> Stud_Course { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Course_ins> Course_ins { get; set; }
        public DbSet<Topic> Topic { get; set; }
    }
}
