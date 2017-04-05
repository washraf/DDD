
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainClasses.Model.Enums;

namespace DomainClasses.Model
{
    public class Teaching
    {
        [Key, Column(Order = 0)]
        public int IntakeId { set; get; }
        [Key, Column(Order = 1)]
        public int InstructorId { set; get; }

        public virtual CourseIntake Intake { set; get; }
        public virtual Instructor FullTimeInstructor { set; get; }

        public decimal ReceivedPayment{ set; get; }

        public Role InstructorCurrentRole { set; get; }
    }
}