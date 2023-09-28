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
	public class FoodMapping : IEntityTypeConfiguration<Food>
	{
		public void Configure(EntityTypeBuilder<Food> builder)
		{
			builder.Property(x => x.Name).HasColumnType("nvarchar(50)").IsRequired();

			builder.Property(x => x.Calories).HasColumnType("decimal(10,2)").IsRequired();

			builder.Property(x => x.Carbohydrate).HasColumnType("decimal(5,2)").IsRequired();

			builder.Property(x => x.Protein).HasColumnType("decimal(5,2)").IsRequired();

			builder.Property(x => x.Fat).HasColumnType("decimal(5,2)").IsRequired();

			builder.HasMany(x => x.Meals).WithMany(x => x.Foods);

			builder.HasOne(x => x.FoodCategory).WithMany(x => x.Foods).HasForeignKey(x => x.CategoryId);

			builder.HasMany(x => x.Portions).WithOne(x => x.Food).HasForeignKey(x => x.FoodId);
		
			builder.Ignore(x => x.TotalQuantity);
		}
	}
}
