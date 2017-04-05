using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClasses.Model;

namespace SingleContextWithAggregateRoots.DataLayer.Context
{
    public class SingleContextWithAggrgateRootsContext : DbContext
    {
        public SingleContextWithAggrgateRootsContext() :
            base("Data Source=.;Initial Catalog=SingleContextWithAggrgateRoots;Integrated Security=True")
        {

        }
        public DbSet<CenterEvent> CenterEvents { set; get; }
        public DbSet<Course> Courses { set; get; }
        public DbSet<Department> Departments { set; get; }
        public DbSet<Student> Students { set; get; }
        public DbSet<Instructor> Instructors { set; get; }
        //public DbSet<Image> Images { set; get; }
        public DbSet<CourseIntake> Intakes { set; get; }
        //public DbSet<Lesson> Lessons { set; get; }
        //public DbSet<StudentSubcription> StudentSubcriptions { set; get; }
        //public DbSet<Teaching> Teachings { set; get; }
        public DbSet<User> Users { set; get; }
    }
}
