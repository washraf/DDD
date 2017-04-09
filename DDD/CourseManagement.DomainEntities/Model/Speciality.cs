using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.SharedData.Model.Enums;

namespace CourseManagement.DomainEntities.Model
{
    public class Speciality
    {
        [Key]
        public virtual SpecialtyType SpecialityName { set; get; }
        public virtual ICollection<Instructor> Instrcutors { set; get; }
    }
}
