using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _16_DBFirst_RepositoryDesing_Nortwind.Repositories;
using GetBalance.DAL;
using GetBalance.DATA;

namespace GetBalance.UI.Repositories
{
	public class FoodMealRepository : GenericRepository<FoodMeal>
	{
		AppDbContext context;
		public FoodMealRepository() : base()
		{
			context = new AppDbContext();
		}
		public void Update(FoodMeal fm)
		{
			FoodMeal foodMeal = GetAll().First(x => x.FoodId == fm.FoodId && x.MealId == fm.MealId);
			foodMeal.FoodId = fm.FoodId;
			foodMeal.FoodAmount = fm.FoodAmount;

			context.SaveChanges();

		}

		public int Delete(FoodMeal fm)
		{
			FoodMeal foodMeal = GetAll().First(x => x.FoodId == fm.FoodId && x.MealId == fm.MealId);
			context.FoodMeal.Remove(foodMeal);

			return context.SaveChanges();
		}
	}
}
