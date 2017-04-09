using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.BaseClasses.Model
{
    [Table("Instructors")]
    internal class Instructor:Employee
    {
        public int HourRate { set; get; }

        public virtual ICollection<Speciality> Specialties { set; get; }
        public virtual ICollection<Teaching> InstructorTeachings { set; get; }
    }
}
