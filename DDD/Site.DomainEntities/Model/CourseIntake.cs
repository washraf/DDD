using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.SharedData.Model.Enums;

namespace Site.DomainEntities.Model
{
    public class CourseIntake
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IntakeId { get; protected set; }
        public Course ToughtCourse { protected set; get; }
        public DateTime StartDateTime {protected set; get; }
        public DateTime EndDateTime {protected set; get; }
        public virtual IReadOnlyCollection<Days> ClassDays { set; get; }
        public virtual ClassTimes ClassTime { protected set; get; }
        public Location EventLocation {protected set; get; }
        //public virtual List<Teaching> TeachingInstructors { set; get; }
        //public virtual List<StudentSubcription> Subcriptions { set; get; }

        
    }
}
