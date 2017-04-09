using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Site.DataSource.Context;
using Site.DataSource.Repositories;
using Site.DataSource.UnitOfWork;
using Site.DomainContracts;
using Site.DomainEntities.Model;

namespace Site.UI
{
    class Program
    {
        static void Main(string[] args)
        {
           // SiteContext context = new SiteContext();
           // var xxx  = context.Users.ToList();

            ICourseIntakeRepository repository = new CourseIntakeRepository(new SiteContext());
            var x = repository.Get();
            foreach (var VARIABLE in x)
            {
                Console.WriteLine(VARIABLE.ClassTime);
            }
        }
    }
}
