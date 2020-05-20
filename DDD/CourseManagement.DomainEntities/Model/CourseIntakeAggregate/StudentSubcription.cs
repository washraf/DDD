using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Utils.Model;
using CourseManagement.DomainEntities.Model.CourseIntakeAggregate;
using CourseManagement.DomainEntities.Model.StudentAggregate;
using CourseManagement.DomainEntities.Model.ValueObjects;

namespace CourseManagement.DomainEntities.Model.CourseIntakeAggregate
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

        public virtual StudentEvaluation StudentEvaluation { set; get; }

        public virtual CourseEvaluation CourseEvaluation { set; get; }
    }
}
