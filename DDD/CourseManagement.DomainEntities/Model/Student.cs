using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement.DomainEntities.Model
{
    [Table("Students")]
    public class Student : User
    {
        public virtual ICollection<StudentSubcription> StudentSubcriptions { set; get; }
    }
}
