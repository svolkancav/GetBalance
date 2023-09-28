using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetBalance.DAL;
using GetBalance.DATA;
using GetBalance.DATA.Enums;

namespace GetBalance.UI.Queries
{
	public class ReportQueries
	{
		AppDbContext _context;
		public ReportQueries(AppDbContext context)
		{
			_context = context;
		}

		public Food? FindMostConsumedFoodByMealType(int userId, DateTime startDate, DateTime endTime, MealType mealType)
		{
			try
			{
				var mostComsumedFood = _context.Meals.Where(meal => meal.UserId == userId && meal.MealType == mealType && meal.Date >= startDate && meal.Date <= endTime)
				.SelectMany(meal => meal.Foods)
				.GroupBy(food => food.FoodId)
				.OrderByDescending(group => group.Count())
				.Select(group => new
				{
					FoodId = group.Key,
					FoodTotalQuantity = group.Sum(food => food.TotalQuantity)
				})
				.FirstOrDefault();

				if (mostComsumedFood != null)
				{
					return _context.Foods.Find(mostComsumedFood.FoodId);
				}
				else return null;

			}
			catch (Exception ex)
			{

				throw new Exception("Sorguda hata oluştu!" + ex.Message);
			}
		}


	}
}
