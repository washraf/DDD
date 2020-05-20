using CourseManagement.DomainEntities.Model;
using CourseManagement.DomainEntities.Model.CourseIntakeAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseMangement.DataSource.EntityConfigurations
{
    class TeachingConfiguration : IEntityTypeConfiguration<Teaching>
    {
        public void Configure(EntityTypeBuilder<Teaching> configuration)
        {
            //Many to many Relationship
            configuration.HasKey(c => new { c.IntakeId, c.InstructorId });
        }
    }
}
