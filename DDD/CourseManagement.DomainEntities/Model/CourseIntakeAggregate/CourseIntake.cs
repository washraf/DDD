using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.SharedData.Events.CourseMangement;
using Common.SharedData.Model.Enums;
using Common.Utils.Events;
using Common.Utils.Model;
using CourseManagement.DomainEntities.Model.CourseAggregate;

namespace CourseManagement.DomainEntities.Model.CourseIntakeAggregate
{

    public class CourseIntake:Entity
    {
        public Course ToughtCourse { set; get; }
        public DateTime StartDateTime { set; get; }
        public DateTime EndDateTime { set; get; }
        public virtual List<Days> ClassDays { set; get; }
        public virtual ClassTimes ClassTime { set; get; }
        public Location EventLocation { set; get; }
        public virtual List<Teaching> TeachingInstructors { set; get; }
        public virtual List<StudentSubcription> Subcriptions { set; get; }
        
        public override bool IsValid => true;

        public override Dictionary<string, string> ValidationErrors => new Dictionary<string, string>();

        public void UpdateSchedule()
        {
            DomainEvent.Raise(new CourseUpdatedEvent()
            {
                CourseName = this.ToughtCourse.CourseName,
                Message = "Dear Student the course is changed"
            });
        }
    }
}
