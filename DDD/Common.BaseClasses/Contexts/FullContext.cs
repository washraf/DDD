using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.BaseClasses.Model;
using Microsoft.EntityFrameworkCore;

namespace Common.BaseClasses.Contexts
{

    internal sealed class FullContext:BaseContext<FullContext>
    {
        internal DbSet<CenterEvent> CenterEvents { set; get; }
        internal DbSet<Course> Courses { set; get; }
        internal DbSet<Department> Departments { set; get; }
        internal DbSet<Student> Students { set; get; }
        internal DbSet<Employee> Employee { set; get; }
        internal DbSet<Image> Images { set; get; }
        internal DbSet<CourseIntake> Intakes { set; get; }
        internal DbSet<Lesson> Lessons { set; get; }
        internal DbSet<StudentSubcription> StudentSubcriptions { set; get; }
        internal DbSet<Teaching> Teachings { set; get; }
        internal DbSet<User> Users { set; get; }
    }
}
