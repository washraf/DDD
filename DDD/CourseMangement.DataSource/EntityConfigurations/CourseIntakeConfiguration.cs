using Common.SharedData.Model.Enums;
using CourseManagement.DomainEntities.Model.CourseIntakeAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseMangement.DataSource.EntityConfigurations
{
    class CourseIntakeConfiguration : IEntityTypeConfiguration<CourseIntake>
    {
        public void Configure(EntityTypeBuilder<CourseIntake> configuration)
        {
            var daysConvertor = new ValueConverter<List<Days>, string>(
               v => String.Join(",", v.Cast<int>().ToList().Select(x => x.ToString())),
               v => v.Split(',').Select(x => (Days)Int32.Parse(x)).ToList());
            configuration.Property(x => x.ClassDays).HasConversion(daysConvertor);
        }
    }
}
