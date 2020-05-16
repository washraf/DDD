using CourseManagement.ApplicationServices.Contracts;
using CourseManagement.ApplicationServices.Implementation;
using CourseManagement.DataSource;
using CourseManagement.DataSource.Repositories;
using CourseManagement.DomainEntities.Model;
using System;

namespace CourseManagement.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            ICourseManager manager = new CourseManager(new CourseRepository(new CourseManagementContext()));
            var courses = manager.GetAllCourses();
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.CourseId}: {course.CourseName}" );

            }
        }
    }
}
