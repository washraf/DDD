using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainClasses.Model.Enums;

namespace DomainClasses.Model
{

    public class Speciality
    {
        [Key]
        public virtual SpecialtyType SpecialityName { set; get; }
        public virtual ICollection<Instructor> Instrcutors { set; get; } 
    }
}
