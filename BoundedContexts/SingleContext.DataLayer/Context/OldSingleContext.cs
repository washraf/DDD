using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using DomainClasses.Model;
using DomainClasses.Model.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SingleContext.DataLayer.Context
{
    public class OldSingleContext : DbContext
    {
        private const string connectionString
            = "Data Source=.;Initial Catalog=OldSingleContext;Integrated Security=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<StudentSubcription>().HasKey(c => new { c.IntakeId, c.StudentId });
            modelBuilder.Entity<Teaching>().HasKey(c => new { c.IntakeId, c.InstructorId });
            base.OnModelCreating(modelBuilder);
            var daysConvertor = new ValueConverter<List<Days>, string>(
                v => String.Join(",", v.Cast<int>().ToList().Select(x => x.ToString())),
                v => v.Split(',').Select(x => (Days)Int32.Parse(x)).ToList());
            modelBuilder.Entity<CourseIntake>().Property(x => x.ClassDays).HasConversion(daysConvertor);

        }


        public DbSet<CenterEvent> CenterEvents { set; get; }
        public DbSet<Course> Courses { set; get; }
        public DbSet<Department> Departments { set; get; }
        public DbSet<Student> Students { set; get; }
        public DbSet<Employee> Employee { set; get; }
        public DbSet<Image> Images { set; get; }
        public DbSet<CourseIntake> Intakes { set; get; }
        public DbSet<Lesson> Lessons { set; get; }
        public DbSet<StudentSubcription> StudentSubcriptions { set; get; }
        public DbSet<Teaching> Teachings { set; get; }
        public DbSet<User> Users { set; get; }
    }
}
