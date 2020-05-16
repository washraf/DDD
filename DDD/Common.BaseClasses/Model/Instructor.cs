using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.BaseClasses.Model
{
    [Table(nameof(Instructor))]
    internal class Instructor:Employee
    {
        public int HourRate { set; get; }

        public string Skills { set; get; }
        public virtual ICollection<Teaching> InstructorTeachings { set; get; }
    }
}
