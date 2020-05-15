using DomainClasses.Model;
using MultipleContext;
using System;

namespace MultipleContexts.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CourseManagementContext context = new CourseManagementContext())
            {
                context.Users.Add(new Student()
                {
                    Address = "Address",
                    BirthDate = DateTime.Now,
                    Name = "Walid",
                    Phone = "0100"
                });
                context.SaveChanges();
            }

            using (WebSiteContext context = new WebSiteContext())
            {
                context.Courses.Add(new Course()
                {
                    CourseDays = 2,
                    CourseDescription = "DDD",
                    CourseName = "DDD",
                });
                context.SaveChanges();
            }
        }
    }
}
