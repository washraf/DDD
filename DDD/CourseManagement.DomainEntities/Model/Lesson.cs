using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement.DomainEntities.Model
{
    public class Lesson
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LessonId { protected set; get; }
        public string LessonName { set; get; }
        public string LessonDescription { set; get; }

        public Course MainCourse { set; get; }
    }
}
