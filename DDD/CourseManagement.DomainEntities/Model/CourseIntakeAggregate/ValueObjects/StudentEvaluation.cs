using Common.SharedData.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement.DomainEntities.Model.ValueObjects
{
    public class StudentEvaluation
    {
        protected StudentEvaluation()
        {

        }

        public StudentEvaluation(int total, LetterGrades grade)
        {
            Total = total;
            Grade = grade;
        }
        public int Total { private set; get; }
        public LetterGrades Grade { get; private set; }
    }
}
