using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagement.ApplicationServices.Contracts;
using CourseManagement.ApplicationServices.Implementation;
using CourseManagement.DataSource;
using CourseManagement.DataSource.Repositories;
using CourseManagement.DomainEntities.Model;
using CoursesManagement.DomainContracts;

namespace CourseManagement.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            ICourseManager manager = new CourseManager(new CourseRepository(new CourseManagementContext()));
            manager.UpdateCourseIntake(null);
        }
    }
}
