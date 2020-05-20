using CourseManagement.DomainEntities.Model.InstructorAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseMangement.DataSource.EntityConfigurations
{
    class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> configuration)
        {
            //Many to many Relationship
            configuration.OwnsMany(x=>x.Certificates, i =>
            {
                i.WithOwner().HasForeignKey("InstructorId");
                i.Property<int>("Id");
                i.HasKey("Id");
                //i.HasKey("InstructorId","Name");
            });
        }
    }
}
