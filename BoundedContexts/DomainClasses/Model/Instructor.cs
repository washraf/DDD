using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.Model
{
    [Table(nameof(Instructor))]
    public class Instructor:Employee
    {
        public int HourRate { set; get; }

        public string Skills { set; get; }
        public virtual ICollection<Teaching> InstructorTeachings { set; get; }
    }
}
