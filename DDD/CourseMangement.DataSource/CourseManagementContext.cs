using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.BaseClasses;
using Common.BaseClasses.Contexts;
using CourseManagement.DataSource.UnitOfWork;
using CourseManagement.DomainEntities.Model;
using CourseManagement.DomainEntities.Model.CourseAggregate;
using CourseManagement.DomainEntities.Model.CourseIntakeAggregate;
using CourseManagement.DomainEntities.Model.InstructorAggregate;
using CourseManagement.DomainEntities.Model.StudentAggregate;
using CourseMangement.DataSource.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CourseManagement.DataSource
{
    public class CourseManagementContext:BaseContext,
        ICourseManagementUnitOfWork
    {
        public DbSet<Course> Courses { set; get; }
        public DbSet<CourseIntake> CourseIntakes { set; get; }
        public DbSet<Instructor> Instructors { set; get; }
        public DbSet<Student> Students { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new CourseIntakeConfiguration());
            modelBuilder.ApplyConfiguration(new StudentSubcriptionConfiguration());
            modelBuilder.ApplyConfiguration(new TeachingConfiguration());
            modelBuilder.ApplyConfiguration(new InstructorConfiguration());

            base.OnModelCreating(modelBuilder);
           

        }
    }
}
