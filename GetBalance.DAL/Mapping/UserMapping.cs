using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetBalance.DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GetBalance.DAL.Mapping
{
	public class UserMapping : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.Property(x => x.UserId).HasColumnOrder(order: 0);

			builder.Property(x => x.Email).IsRequired().HasColumnType("nvarchar(50)").HasColumnOrder(order: 1);

			builder.Property(x=>x.Password).IsRequired().HasColumnType("nvarchar(30)").HasColumnOrder(order:2);
		}
	}
}
