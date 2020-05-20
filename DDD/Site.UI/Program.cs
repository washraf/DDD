using Site.DataSource.Context;
using Site.DataSource.Repositories;
using Site.DomainContracts;
using System;
using System.Linq;

namespace Site.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            ICourseIntakeRepository repository = new CourseIntakeRepository(new SiteContext());
            var intakes = repository.Get().ToList();
            foreach (var intake in intakes)
            {
                Console.WriteLine(intake.StartDateTime);
            }
        }
    }
}
