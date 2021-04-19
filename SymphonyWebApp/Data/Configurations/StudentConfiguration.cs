using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SymphonyWebApp.Data.Entities;
using SymphonyWebApp.Data.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Data.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.RollNumber).IsRequired().HasMaxLength(10).IsUnicode(false);
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Gmail).IsRequired().HasMaxLength(100);
            builder.Property(x => x.IdentityCard).IsRequired().HasMaxLength(20);
            builder.Property(x => x.StudentStatus).IsRequired().HasDefaultValue(StudentStatus.Studying);
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(12);
            builder.Property(x => x.Dob).IsRequired();
            builder.Property(x => x.SubFee).IsRequired();

            builder.Property(x => x.ClassId).IsRequired().HasMaxLength(10).IsUnicode(false);
            builder.Property(x => x.CourseId).IsRequired().HasMaxLength(10).IsUnicode(false);

            builder.HasOne(x => x.ClassStudy).WithMany(x => x.Students).HasForeignKey(x => x.ClassId);
            builder.HasOne(x => x.Course).WithMany(x => x.Students).HasForeignKey(x => x.CourseId);
        }
    }
}