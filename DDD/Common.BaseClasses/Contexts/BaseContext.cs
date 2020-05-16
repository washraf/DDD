using Common.BaseClasses.Model;
using Common.SharedData.Model.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.BaseClasses.Contexts
{
    public class BaseContext<TContext> : DbContext where TContext : DbContext
    {
        private const string connectionString
            = "Data Source=.;Initial Catalog=DDD;Integrated Security=True";

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

        public void Commit()
        {
            this.SaveChanges();
        }

        public DbSet<TEntityType> GetDBSet<TEntityType>() where TEntityType : class, new()
        {
            return this.Set<TEntityType>();
        }
    }
}
