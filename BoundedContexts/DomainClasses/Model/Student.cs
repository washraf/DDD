using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.Model
{
    [Table(nameof(Student))]
    public class Student:User
    {
        public virtual ICollection<StudentSubcription> StudentSubcriptions { set; get; }
    }
}
