using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SymphonyWebApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Data.Configurations
{
    public class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CourseId).IsRequired().HasMaxLength(10);
            builder.Property(x => x.CourseName).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Fee).IsRequired().HasMaxLength(20);
            builder.Property(x => x.SubFee).IsRequired().HasMaxLength(20);
            builder.Property(x => x.FeeStatus).IsRequired().HasMaxLength(20);
            builder.Property(x => x.TrainingTime).IsRequired().HasMaxLength(20);
            builder.Property(x => x.StartTime).IsRequired().HasMaxLength(20);
            builder.Property(x => x.EndTime).IsRequired().HasMaxLength(20);
        }
    }
}
