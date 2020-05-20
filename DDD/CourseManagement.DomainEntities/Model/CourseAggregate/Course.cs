using Common.Utils.Model;
using Common.Utils.Validation;
using CourseManagement.DomainEntities.Model.CourseIntakeAggregate;
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
    public class Course:Entity
    {
        public string CourseName { set; get; }
        public int CourseDays { set; get; }
        public string CourseDescription { set; get; }
        public virtual ICollection<CourseIntake> CourseIntakes { set; get; }
        public virtual ICollection<Lesson> Lessons { set; get; }

        public override bool IsValid
        {
            get
            {
                var v = new CourseValidator();
                var result = v.Validate(this);
                return result.IsValid && IsCourseLegal();
            }
        }

        public override Dictionary<string, string> ValidationErrors

        {
            get
            {
                var v = new CourseValidator();
                var result = v.Validate(this);
                var dictionary =  result.ToDictionary();
                if(!IsCourseLegal())
                {
                    dictionary.Add("Legal", "Course Cannot be Illegal");
                }
                return dictionary;
            }
        }

        protected bool IsCourseLegal()
        {
            return CourseName.ToString().Contains("illegal");
        }
    }

}
