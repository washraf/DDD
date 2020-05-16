using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.BaseClasses;
using Common.BaseClasses.Contexts;
using CourseManagement.DataSource.UnitOfWork;
using CourseManagement.DomainEntities.Model;
using Microsoft.EntityFrameworkCore;

namespace CourseManagement.DataSource
{
    public class CourseManagementContext:BaseContext<CourseManagementContext>,
        ICourseManagementUnitOfWork
    {
        public DbSet<Course> Courses { set; get; }
        public DbSet<CourseIntake> Intakes { set; get; }
        public DbSet<Instructor> Instructors { set; get; }
        public DbSet<Student> Students { set; get; }
    }
}
