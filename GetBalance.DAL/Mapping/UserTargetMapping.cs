using GetBalance.DATA.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBalance.DAL.Mapping
{
    internal class UserTargetMapping : IEntityTypeConfiguration<UserTarget>
    {
        public void Configure(EntityTypeBuilder<UserTarget> builder)
        {
            builder.Property(x => x.StartingWeight).IsRequired().HasColumnType("decimal(6,2)");
            builder.Property(x => x.TargetWeight).IsRequired().HasColumnType("decimal(6,2)");
            builder.Property(x => x.TargetCalorie).IsRequired().HasColumnType("decimal(6,2)");
            builder.Property(x => x.TargetCarbPercentage).IsRequired().HasColumnType("decimal(5,2)");
            builder.Property(x => x.TargetProteinPercentage).IsRequired().HasColumnType("decimal(5,2)");
            builder.Property(x => x.TargetFatPercentage).IsRequired().HasColumnType("decimal(5,2)");

            builder.HasOne(x => x.UserDetail).WithOne(x => x.UserTarget).HasForeignKey<UserTarget>(x => x.UserDetailId);
        }
    }
}
