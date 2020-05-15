using DomainClasses.Model.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainClasses.Model.ValueObjects
{
    public class StudentEvaluation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
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