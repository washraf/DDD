using Common.Utils.Model;
using Common.Utils.Validation;
using CourseManagement.DomainEntities.Validation.CourseAggregate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement.DomainEntities.Model.CourseAggregate
{
    public class Lesson:Entity
    {
        public string LessonName { set; get; }
        public string LessonDescription { set; get; }

        public Course MainCourse { set; get; }

        public override bool IsValid
        {
            get
            {
                var v = new LessonValidator();
                var result = v.Validate(this);
                return result.IsValid;
            }
        }

        public override Dictionary<string, string> ValidationErrors

        {
            get
            {
                var v = new LessonValidator();
                var result = v.Validate(this);
                return result.ToDictionary();

            }
        }
    }
}
