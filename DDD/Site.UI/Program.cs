using Site.DataSource.Context;
using Site.DataSource.Repositories;
using Site.DomainContracts;
using System;

namespace Site.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            ICourseIntakeRepository repository = new CourseIntakeRepository(new SiteContext());
            var x = repository.Get();
            foreach (var VARIABLE in x)
            {
                Console.WriteLine(VARIABLE.ClassTime);
            }
        }
    }
}
