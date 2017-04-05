using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using DomainClasses.Model;

namespace SingleContext.DataLayer.Context
{
    public class OldSingleContext : DbContext
    {
        public OldSingleContext():
            base("Data Source=.;Initial Catalog=OldSingleContext;Integrated Security=True")
        {
            
        }
        public DbSet<CenterEvent> CenterEvents { set; get;}
        public DbSet<Course> Courses { set; get;}
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
