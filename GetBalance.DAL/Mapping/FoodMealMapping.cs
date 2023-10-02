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
    public class FoodMealMapping : IEntityTypeConfiguration<FoodMeal>
	{
		public void Configure(EntityTypeBuilder<FoodMeal> builder)
		{
			builder.Ignore(x=>x.TotalCalori);
			builder.Ignore(x=>x.TotalCarb);
			builder.Ignore(x=>x.TotalProtein);
			builder.Ignore(x=>x.TotalFat);

			builder.Property(fm => fm.FoodAmount).IsRequired();

			builder.HasKey(fm => new { fm.FoodId, fm.MealId });

			builder.HasOne(fm => fm.Food).WithMany(f => f.FoodMeals).HasForeignKey(fm => fm.FoodId);
			builder.HasOne(fm => fm.Meal).WithMany(m => m.MealFoods).HasForeignKey(fm => fm.MealId);
		}
	}
}
