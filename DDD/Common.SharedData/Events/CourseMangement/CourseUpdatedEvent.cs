using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Utils.Events;

namespace Common.SharedData.Events.CourseMangement
{
    public class CourseUpdatedEvent:IDomainEvent
    {
        public string CourseName { set; get; }
        public string Message { set; get; }
    }
}
