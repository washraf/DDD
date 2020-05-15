using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClasses.Model;
using Microsoft.EntityFrameworkCore;

namespace MultipleContext
{
    public class CourseManagementContext:BaseContext<CourseManagementContext>
    {
        public DbSet<Course> Courses { set; get; }
        public DbSet<CourseIntake> Intakes { set; get; }
        public DbSet<Instructor> Instructors { set; get; }
        public DbSet<User> Users { set; get; } 
    } 
}
