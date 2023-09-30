using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBalance.DATA
{
	public class FoodMeal
	{
        public int FoodId { get; set; }
		public int MealId { get; set; }
		public int FoodAmount { get; set; }
		public double TotalCalori => Food.Calories * FoodAmount;
		public double TotalCarb => Food.Carbohydrate * FoodAmount;
		public double TotalProtein => Food.Protein * FoodAmount;
		public double TotalFat => Food.Fat * FoodAmount;
		public Food Food { get; set; }
		public Meal Meal { get; set; }
    }
}
