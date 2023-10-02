using GetBalance.DATA.Enums;

namespace GetBalance.DATA.Entities
{
    public class Meal
    {
        public Meal()
        {
            MealFoods = new HashSet<FoodMeal>();
        }
        public int MealId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public MealType MealType { get; set; }
        public double TotalCalories => MealFoods.Sum(fm => fm.TotalCalori);
        public double TotalCarbohydrate => MealFoods.Sum(fm => fm.TotalCarb);
        public double TotalProtein => MealFoods.Sum(fm => fm.TotalProtein);
        public double TotalFat => MealFoods.Sum(fm => fm.TotalFat);
        public int UserId { get; set; }

        public User User { get; set; }
        public ICollection<FoodMeal> MealFoods { get; set; }
    }
}