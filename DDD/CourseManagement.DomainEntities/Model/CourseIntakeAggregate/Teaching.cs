using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.SharedData.Model.Enums;
using CourseManagement.DomainEntities.Model.CourseIntakeAggregate;
using CourseManagement.DomainEntities.Model.InstructorAggregate;

namespace CourseManagement.DomainEntities.Model.CourseIntakeAggregate
{
    public class Teaching
    {
        [Key, Column(Order = 0)]
        public int IntakeId { set; get; }
        [Key, Column(Order = 1)]
        public int InstructorId { set; get; }

        public virtual CourseIntake Intake { set; get; }
        public virtual Instructor FullTimeInstructor { set; get; }

        public decimal ReceivedPayment { set; get; }

        public Role InstructorCurrentRole { set; get; }
    }
}
