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
	public class PortionMapping : IEntityTypeConfiguration<Portion>
	{
		public void Configure(EntityTypeBuilder<Portion> builder)
		{
			builder.Property(x=>x.Quantity).IsRequired().HasColumnType("decimal(4,2)");

			builder.Property(x => x.PortionName).IsRequired();
		}
	}
}
