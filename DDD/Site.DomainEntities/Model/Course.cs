using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.DomainEntities.Model
{
    public class Course
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { protected set; get; }
        public string CourseName { set; get; }
        public int CourseDays { set; get; }
        //public string CourseDescription { set; get; }
        //public virtual ICollection<CourseIntake> Intakes { set; get; }
        //public virtual ICollection<Lesson> Lessons { set; get; }
    }
}
