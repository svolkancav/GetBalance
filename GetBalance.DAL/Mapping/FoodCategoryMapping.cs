using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetBalance.DATA.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GetBalance.DAL.Mapping
{
    public class FoodCategoryMapping : IEntityTypeConfiguration<FoodCategory>
	{
		public void Configure(EntityTypeBuilder<FoodCategory> builder)
		{
			builder.Property(x => x.Name).HasColumnType("nvarchar(50)").IsRequired();
		}
	}
}
