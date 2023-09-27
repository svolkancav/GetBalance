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
			builder.Property(x=>x.Quantity).IsRequired();

			builder.Property(x => x.PortionName).IsRequired();
			
			builder.HasIndex(x => new { x.FoodId, x.PortionName }).IsUnique();

			builder.HasOne(x => x.Food).WithMany(x => x.Portions).HasForeignKey(x => x.FoodId);
		}
	}
}
