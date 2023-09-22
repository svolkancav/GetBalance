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
	public class MealMapping : IEntityTypeConfiguration<Meal>
	{
		public void Configure(EntityTypeBuilder<Meal> builder)
		{
			builder.Property(x => x.Name).IsRequired().HasColumnType("nvarchar(50)");

			builder.Property(x => x.Date).IsRequired().HasColumnType("datetime2");

			builder.Property(x=>x.MealType).IsRequired().HasColumnType("int");

			builder.Ignore(x => x.Calories);
			builder.Ignore(x => x.Carbohydrate);
			builder.Ignore(x => x.Fat);
			builder.Ignore(x => x.Protein);

			builder.HasOne(x => x.User).WithMany(x => x.Meals).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade);

			builder.HasMany(x => x.Foods).WithMany(x => x.Meals);
		}
	}
}
