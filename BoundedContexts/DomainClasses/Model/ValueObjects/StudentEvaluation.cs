using DomainClasses.Model.Enums;

namespace DomainClasses.Model.ValueObjects
{
    public class StudentEvaluation
    {
        protected StudentEvaluation()
        {

        }

        public StudentEvaluation(Rating attendence, Rating courseWork,
            Rating assignments, Rating graduationProject)
        {
            Attendence = attendence;
            CourseWork = CourseWork;
            Assignments = Assignments;
            GraduationProject = GraduationProject;
        }
        public Rating Attendence { set; get; }
        public Rating CourseWork { set; get; }
        public Rating Assignments { set; get; }
        public Rating GraduationProject { set; get; }
    }
}