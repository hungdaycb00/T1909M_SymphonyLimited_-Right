using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SymphonyWebApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Data.Configurations
{
    public class ResultTestConfiguration : IEntityTypeConfiguration<ResultTest>
    {
        public void Configure(EntityTypeBuilder<ResultTest> builder)
        {
            builder.ToTable("ResultTests");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.RollNumber).IsRequired().HasMaxLength(10).IsUnicode(false);
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Gmail).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Fee).IsRequired();

            builder.Property(x => x.ClassName).IsRequired();
            builder.Property(x => x.CourseName).IsRequired();
        }
    }
}