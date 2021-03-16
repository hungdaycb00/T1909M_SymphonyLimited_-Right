using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SymphonyWebApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Data.Configurations
{
    public class RegistrationTestConfiguration : IEntityTypeConfiguration<RegistrationTest>
    {
        public void Configure(EntityTypeBuilder<RegistrationTest> builder)
        {
            builder.ToTable("RegistrationTests");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CourseName).IsRequired();
        }
    }
}