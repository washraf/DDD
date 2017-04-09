using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagement.DomainEntities.Model.ValueObjects;

namespace CourseManagement.DomainEntities.Model
{
    public class StudentSubcription
    {
        [Key, Column(Order = 0)]
        public int IntakeId { set; get; }
        [Key, Column(Order = 1)]
        public int StudentId { set; get; }
        public virtual CourseIntake Intake { set; get; }
        public virtual Student CurrentStudent { set; get; }

        public decimal Payed { set; get; }

        public virtual StudentEvaluation CourseScore { set; get; }

        public virtual CourseEvaluation StudentEvaluation { set; get; }
    }
}
