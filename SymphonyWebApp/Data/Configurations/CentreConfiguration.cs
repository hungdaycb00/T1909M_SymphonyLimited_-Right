using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SymphonyWebApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Data.Configurations
{
    public class CentreConfiguration : IEntityTypeConfiguration<Centre>
    {
        public void Configure(EntityTypeBuilder<Centre> builder)
        {
            builder.ToTable("Centres");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Address).IsRequired().HasMaxLength(100);
        }
    }
}
