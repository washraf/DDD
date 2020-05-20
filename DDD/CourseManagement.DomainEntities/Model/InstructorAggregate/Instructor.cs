using Common.Utils.Model;
using CourseManagement.DomainEntities.Model.CourseIntakeAggregate;
using CourseManagement.DomainEntities.Model.InstructorAggregate.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement.DomainEntities.Model.InstructorAggregate
{
    public class Instructor : Entity
    {
        public string Name { set; get; }
        public string Email { set; get; }
        public int HourRate { set; get; }

        public virtual string Skills { set; get; }

        public virtual List<Certificates> Certificates { set; get; }
        public virtual ICollection<Teaching> InstructorTeachings { set; get; }

        public override bool IsValid => true;

        public override Dictionary<string, string> ValidationErrors => new Dictionary<string, string>();
    }
}
