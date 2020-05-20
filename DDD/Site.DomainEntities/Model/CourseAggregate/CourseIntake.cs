using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.SharedData.Model.Enums;
using Common.Utils.Model;

namespace Site.DomainEntities.Model
{
    public class CourseIntake:Entity
    {
        public Course ToughtCourse { set; get; }
        public DateTime StartDateTime { set; get; }
        public Location EventLocation { set; get; }

        public override bool IsValid => true;

        public override Dictionary<string, string> ValidationErrors => new Dictionary<string, string>();
    }
}
