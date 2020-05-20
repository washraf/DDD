using Common.Utils.Model;
using CourseManagement.DomainEntities.Model.CourseIntakeAggregate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement.DomainEntities.Model.StudentAggregate
{
    public class Student : Entity
    {
        public string Name { set; get; }
        public string Email { set; get; }
        //public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<StudentSubcription> StudentSubcriptions { set; get; }

        public override bool IsValid => true;

        public override Dictionary<string, string> ValidationErrors => new Dictionary<string, string>();
    }
}
