using CourseManagement.DomainEntities.Model.CourseAggregate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagement.DomainEntities.Validation.CourseAggregate
{
    internal class LessonValidator:AbstractValidator<Lesson>
    {
        public LessonValidator()
        {
            RuleFor(x => x.LessonName).NotEmpty();
            RuleFor(x => x.LessonDescription).NotEmpty();
        }
    }
}
