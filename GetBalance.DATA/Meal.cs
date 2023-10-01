using GetBalance.DATA.Enums;

namespace GetBalance.DATA
{
	public class Meal
	{
		public Meal()
		{
			MealFoods = new HashSet<FoodMeal>();
		}
		public int MealId { get; set; }
		public string Name { get; set; }
		public double Calories { get; set; }
		public double Protein { get; set; }
		public double Carbohydrate { get; set; }
		public double Fat { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public MealType MealType { get; set; }
		//public double TotalCalories => Foods.Sum(food => food.Calories * food.TotalQuantity);
        public int UserId { get; set; }

		public User User { get; set; }
        public ICollection<FoodMeal> MealFoods { get; set; }
    }
}