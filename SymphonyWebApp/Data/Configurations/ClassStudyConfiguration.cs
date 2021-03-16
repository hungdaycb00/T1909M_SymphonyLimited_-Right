using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SymphonyWebApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Data.Configurations
{
    public class ClassStudyConfiguration : IEntityTypeConfiguration<ClassStudy>
    {
        public void Configure(EntityTypeBuilder<ClassStudy> builder)
        {
            builder.ToTable("ClassStudies");
            builder.HasKey(x => x.ClassId);
            builder.Property(x => x.ClassId).IsRequired().HasMaxLength(5).IsUnicode(false);
            builder.Property(x => x.Id).UseIdentityColumn().IsRequired();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

            builder.HasMany<Course>(x => x.Courses).WithMany(x => x.ClassStudies);
        }
    }
}