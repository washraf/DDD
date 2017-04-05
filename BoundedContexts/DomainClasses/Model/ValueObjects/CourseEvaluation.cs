using DomainClasses.Model.Enums;

namespace DomainClasses.Model.ValueObjects
{
    public class CourseEvaluation
    {
        protected CourseEvaluation()
        {
            
        }

        public CourseEvaluation(Rating instructor,Rating center,
            Rating content,Rating tools)
        {
            InstructorRating = instructor;
            CenterRating = center;
            ContentRating = content;
            ToolsRating = tools;
        }
        public Rating InstructorRating { protected set; get; }
        public Rating CenterRating {protected set; get; }
        public Rating ContentRating {protected set; get; }
        public Rating ToolsRating {protected set; get; }
    }
}