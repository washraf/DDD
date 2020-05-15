using DomainClasses.Model;
using Microsoft.EntityFrameworkCore;

namespace MultipleContext
{
    public class FullContext:BaseContext<FullContext>
    {
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
