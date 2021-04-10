﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SymphonyWebApp.Data.Entities;
using SymphonyWebApp.Data.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Data.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Gmail).IsRequired().HasMaxLength(50);
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(12);
            builder.Property(x => x.Contents).HasMaxLength(200).IsRequired();
            builder.Property(x => x.CreatingDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.customerStatus).HasDefaultValue(CustomerStatus.Uncomfirm);

            builder.HasOne(r => r.TestRoom).WithMany(c => c.Customers).HasForeignKey(f => f.TestRoomId);
        }
    }
}