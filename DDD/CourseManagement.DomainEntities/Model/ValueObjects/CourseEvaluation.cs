using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.SharedData.Model.Enums;

namespace CourseManagement.DomainEntities.Model.ValueObjects
{
    public class CourseEvaluation
    {
        protected CourseEvaluation()
        {

        }

        public CourseEvaluation(Rating instructor, Rating center,
            Rating content, Rating tools)
        {
            InstructorRating = instructor;
            CenterRating = center;
            ContentRating = content;
            ToolsRating = tools;
        }
        public Rating InstructorRating { protected set; get; }
        public Rating CenterRating { protected set; get; }
        public Rating ContentRating { protected set; get; }
        public Rating ToolsRating { protected set; get; }
    }

}
