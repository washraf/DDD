using CourseManagement.DomainEntities.Model;
using CourseManagement.DomainEntities.Model.CourseAggregate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
namespace CourseManagement.DomainEntities.Validation.CourseAggregate
{
    internal class CourseValidator:AbstractValidator<Course>
    {
        public CourseValidator()
        {
            RuleFor(x => x.CourseName).NotEmpty();
            RuleFor(x => x.CourseDescription).NotEmpty();
            RuleFor(x => x.CourseDays).NotEmpty();
            RuleForEach(x => x.Lessons).SetValidator(new LessonValidator());
        }
    }
}
