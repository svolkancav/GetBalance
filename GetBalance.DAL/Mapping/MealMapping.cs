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
    public class MealMapping : IEntityTypeConfiguration<Meal>
	{
		public void Configure(EntityTypeBuilder<Meal> builder)
		{
			builder.Property(x => x.Name).IsRequired().HasColumnType("nvarchar(50)");

			builder.Property(x => x.Date).IsRequired().HasColumnType("date");

			builder.Property(x=>x.MealType).IsRequired().HasColumnType("int");

			builder.Ignore(x => x.TotalCalories);
			builder.Ignore(x => x.TotalCarbohydrate);
			builder.Ignore(x => x.TotalProtein);
			builder.Ignore(x => x.TotalFat);

			builder.HasOne(x => x.User).WithMany(x => x.Meals).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade);

			builder.HasMany(x => x.MealFoods).WithOne(x => x.Meal);
		}
	}
}
