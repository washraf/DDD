using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.SharedData.Events.CourseMangement;
using Common.Utils.Events;
using Site.DataSource.Context;
using Site.DataSource.Repositories;
using Site.DomainContracts;

namespace Site.ApplicationServices.EventHandlers
{
    public class CourseUpdatedHandler : 
        IDomainHandler<CourseUpdatedEvent>
    {
        public void Handle(CourseUpdatedEvent args)
        {
            //ICourseIntakeRepository repository = 
            //    new CourseIntakeRepository(new SiteContext());
            using (StreamWriter writer = 
                new StreamWriter("D:/Out.txt",true))
            {
                writer.WriteLine("Course: " + args.CourseName 
                    + "\t-\t" + args.Message);
                //writer.Flush();
            }

        }
    }
}
