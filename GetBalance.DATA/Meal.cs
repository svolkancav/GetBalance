using GetBalance.DATA.Enums;

namespace GetBalance.DATA
{
	public class Meal
	{
		public int MealId { get; set; }
		public string Name { get; set; }
		public double Calories { get; set; }
		public double Protein { get; set; }
		public double Carbohydrate { get; set; }
		public double Fat { get; set; }
        public DateTime Date { get; set; }
        public MealType MealType { get; set; }
        public int UserId { get; set; }

		public User User { get; set; }
        public ICollection<Food> Foods { get; set; }
    }
}