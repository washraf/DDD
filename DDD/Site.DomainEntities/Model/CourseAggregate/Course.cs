using Common.Utils.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.DomainEntities.Model
{
    public class Course:Entity
    {
        public string CourseName { get; private set; }
        public int CourseDays { get; private set; }
        public virtual ICollection<CourseIntake> CourseIntakes { set; get; }

        public override bool IsValid => true;

        public override Dictionary<string, string> ValidationErrors => new Dictionary<string, string>();
    }
}
