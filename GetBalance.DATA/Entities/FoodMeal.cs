using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetBalance.DATA.Enums;

namespace GetBalance.DATA.Entities
{
    public class FoodMeal
    {
        public int FoodId { get; set; }
        public int MealId { get; set; }

        public int FoodAmount { get; set; }

        public double TotalCalori => Math.Round(Food.Calories * FoodAmount / (Food.PortionName == PortionName.gram ? 100.0 : 1.0), 2);
        public double TotalCarb => Math.Round(Food.Carbohydrate * FoodAmount / (Food.PortionName == PortionName.gram ? 100.0 : 1.0), 2);
        public double TotalProtein => Math.Round(Food.Protein * FoodAmount / (Food.PortionName == PortionName.gram ? 100.0 : 1.0), 2);
        public double TotalFat => Math.Round(Food.Fat * FoodAmount / (Food.PortionName == PortionName.gram ? 100.0 : 1.0), 2);
        public Food Food { get; set; }
        public Meal Meal { get; set; }
    }
}
