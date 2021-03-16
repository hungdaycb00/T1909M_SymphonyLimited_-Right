using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SymphonyWebApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Data.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses");
            builder.HasKey(x => x.CourseId);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CourseId).IsRequired().HasMaxLength(5).IsUnicode(false);
            builder.Property(x => x.CourseName).IsRequired().HasMaxLength(10);
            builder.Property(x => x.TrainingTime).IsRequired();
            builder.Property(x => x.Fee).IsRequired();
            builder.Property(x => x.level).IsRequired();
            builder.HasMany<ClassStudy>(x => x.ClassStudies).WithMany(x => x.Courses);
        }
    }
}