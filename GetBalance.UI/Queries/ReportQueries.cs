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

		//public MostConsumedFoodType FindMostConsumedFoodByMealType(int userId, MealType mealType, out int foodQuantity)
		//{
		//	DateTime startDate = DateTime.Now.AddDays(-7);
		//	DateTime endTime = DateTime.Now;
		//	foodQuantity = 0;
		//	try
		//	{
		//		MostConsumedFoodType? mostComsumedFood = _context.Meals.Where(meal => meal.UserId == userId && meal.MealType == mealType && meal.Date >= startDate && meal.Date <= endTime)
		//		.SelectMany(meal => meal.Foods)
		//		.GroupBy(food => food.FoodId)
		//		.OrderByDescending(group => group.Count())
		//		.Select(group => new MostConsumedFoodType
		//		{
		//			FoodId = group.Key,
		//			FoodName = group.FirstOrDefault().Name,
		//			FoodTotalQuantity = group.Sum(food => food.TotalQuantity)
		//		})
		//		.FirstOrDefault();

		//		if (mostComsumedFood != null)
		//		{
		//			return mostComsumedFood;
		//		}
		//		else return null;

		//	}
		//	catch (Exception ex)
		//	{

		//		throw new Exception("Sorguda hata oluştu!" + ex.Message);
		//	}
		//}

		public class MostConsumedFoodType
		{
			public int FoodId { get; set; }
			public string FoodName { get; set; }
			public int FoodTotalQuantity { get; set; }
		}

		//public List<UserWithTotalCalories> UsersRank(MealType mealType, FoodCategory foodCategory)
		//{
		//	DateTime startDate = DateTime.Now.AddDays(-7);
		//	DateTime endTime = DateTime.Now;
		//	try
		//	{
		//		//List<Meal> filteredMeals = _context.Meals
		//		//	.Where(m => m.MealType == mealType &&
		//		//	m.Foods.Any(f => f.FoodCategory == foodCategory) &&
		//		//	m.Date >= startDate && m.Date <= endTime).ToList();
					
		//		//List<UserWithTotalCalories> usersWithTotalCalories = filteredMeals.
		//		//	Select(m=>new UserWithTotalCalories { 
		//		//		UserId=m.UserId,
		//		//		UserFullName=m.User.UserDetail.FirstName+" "+m.User.UserDetail.LastName,
		//		//		TotalCalories=m.TotalCalories
		//		//	}).OrderByDescending(u=>u.TotalCalories)
		//		//	.ToList();
		//		//return usersWithTotalCalories;
		//	}
		//	catch (Exception ex)
		//	{

		//		throw new Exception("Sorguda hata oluştu!" + ex.Message);
		//	}
		//}


		//UserRank sorgusunda geri dönecek olan model sınıfı
		public class UserWithTotalCalories
		{
			public int UserId { get; set; }
			public string UserFullName { get; set; }
			public double TotalCalories { get; set; }
		}
	}
}
