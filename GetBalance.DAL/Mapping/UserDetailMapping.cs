using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetBalance.DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GetBalance.DAL.Mapping
{
	public class UserDetailMapping : IEntityTypeConfiguration<UserDetail>
	{
		public void Configure(EntityTypeBuilder<UserDetail> builder)
		{
			builder.Property(x => x.FirstName).HasColumnType("nvarchar(50)").IsRequired();

			builder.Property(x => x.LastName).HasColumnType("nvarchar(50)").IsRequired();

			builder.Property(x => x.BirthDate).IsRequired();

			builder.Property(x=>x.Gender).IsRequired().HasColumnType("nvarchar(6)");

			builder.Property(x => x.Height).IsRequired().HasColumnType("decimal(4.2)"); 

			builder.Property(x => x.CurrentWeight).IsRequired().HasColumnType("decimal(4.2)");

			builder.HasOne(x => x.User).WithOne(x => x.UserDetail).HasForeignKey<UserDetail>(x => x.UserId);



		}
	}
}
