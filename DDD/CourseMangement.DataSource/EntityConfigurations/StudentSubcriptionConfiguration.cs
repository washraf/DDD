using CourseManagement.DomainEntities.Model;
using CourseManagement.DomainEntities.Model.CourseIntakeAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseMangement.DataSource.EntityConfigurations
{
    class StudentSubcriptionConfiguration : IEntityTypeConfiguration<StudentSubcription>
    {
        public void Configure(EntityTypeBuilder<StudentSubcription> configuration)
        {
            //Address value object persisted as owned entity type supported since EF Core 2.0
            configuration
                .OwnsOne(o => o.StudentEvaluation, a =>
                {
                    a.WithOwner();
                });
            configuration
                .OwnsOne(o => o.CourseEvaluation, a =>
                {
                    a.WithOwner();
                });

            //Many to many Relationship
            configuration.HasKey(c => new { c.IntakeId, c.StudentId });
        }
    }
}
