using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetBalance.DAL;
using GetBalance.DATA;
using GetBalance.DATA.Enums;
using GetBalance.UI.Repositories;
using GetBalance.UI.Singeltons;
using Microsoft.VisualBasic.ApplicationServices;

namespace GetBalance.UI.Queries
{
	public class DBQueries
	{
		AppDbContext _context;

		public DBQueries()
		{
			_context = new AppDbContext();
		}

		public IList<EnCokTuketilenYemek> EnCokTuketilenYemekListele(MealType mealType,int userId)
		{

			IList<EnCokTuketilenYemek> filteredMeals = (from fm in _context.FoodMeal
														join m in _context.Meals on fm.MealId equals m.MealId
														join f in _context.Foods on fm.FoodId equals f.FoodId
														where m.MealType == mealType && m.UserId == userId
														group f by f.Name into g
														orderby g.Count() descending
														select new EnCokTuketilenYemek
														{
															Name = g.Key,
															Count = g.Count()
														}).ToList();

			return filteredMeals;
		}

		public class EnCokTuketilenYemek
		{
			public string Name { get; set; }
			public int Count { get; set; }
		}

		public IList<Kiyas> GetRank(MealType mealType,int categoryId,bool isMontly)
		{
			int day = isMontly ? 30 : 7;
			

			IList<Kiyas> kiyas = (from fm in _context.FoodMeal
								  join m in _context.Meals on fm.MealId equals m.MealId
								  join f in _context.Foods on fm.FoodId equals f.FoodId
								  join u in _context.Users on m.UserId equals u.UserId
								  where m.MealType == mealType && m.Date >= DateTime.Now.AddDays(-day) && m.Date <= DateTime.Now && f.FoodCategory.FoodCategoryId == categoryId
								  group new { f, u } by new { f.Name, u.UserDetail.FirstName, u.UserDetail.LastName } into g
								  orderby g.Count() descending
								  select new Kiyas
								  {
									  Name = g.Key.FirstName + " " + g.Key.LastName,
									  FoodName = g.Key.Name,
									  Count = g.Count()
								  }).ToList();


			return kiyas;
		}

		public IList<LsvItem> ViewToGetMeals(MealType mealType,int userId,DateTime date)
		{

			List<FoodMeal> userFoodMeals = _context.FoodMeal
				.Join(_context.Meals, fm => fm.MealId, m => m.MealId, (fm, m) => new { fm, m })
				.Where(fm=>fm.m.UserId==userId).
				Select(joined => new FoodMeal
				{
					FoodId = joined.fm.FoodId,
					FoodAmount = joined.fm.FoodAmount,
					MealId = joined.fm.MealId,
				}).ToList();

			foreach (var item in userFoodMeals)
			{
				item.Food = _context.Foods.First(f=>f.FoodId==item.FoodId);
			}

			IList<LsvItem> filteredMeals = userFoodMeals
				.Join(_context.Meals, fm => fm.MealId, m => m.MealId, (fm, m) => new { fm, m })
				.Where(joined =>joined.m.MealType == mealType && joined.m.Date == date)
				.Select(joined => new LsvItem
				{
					FoodMeal = joined.fm,
					Food = joined.fm.Food,
					Name = joined.fm.Food.Name,
					Amount = joined.fm.FoodAmount,
					TotalCalorie = joined.fm.TotalCalori,
					TotalCarb = joined.fm.TotalCarb,
					TotalProtein = joined.fm.TotalProtein,
					TotalFat = joined.fm.TotalFat
				}).ToList();
			return filteredMeals;
		}

		//UserRank sorgusunda geri dönecek olan model sınıfı
		public class UserWithTotalCalories
		{
			public int UserId { get; set; }
			public string UserFullName { get; set; }
			public double TotalCalories { get; set; }
		}

		public class Kiyas
		{
			public string Name { get; set; }
			public string FoodName { get; set; }
			public int Count { get; set; }
		}

		public class LsvItem
		{
			public FoodMeal FoodMeal { get; set; }
			public Food Food { get; set; }
			public string Name { get; set; }
			public int Amount { get; set; }
			public double TotalCalorie { get; set; }
			public double TotalCarb { get; set; }
			public double TotalProtein { get; set; }
			public double TotalFat { get; set; }

		}
	}
}
