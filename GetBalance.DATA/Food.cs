namespace GetBalance.DATA
{
	public class Food
	{
		public int FoodId { get; set; }
		public string Name { get; set; }
		public double Calories { get; set; }
		public double Protein { get; set; }
		public double Carbohydrate { get; set; }
		public double Fat { get; set; }
        public int CategoryId { get; set; }

		public FoodCategory FoodCategory { get; set; }
        public ICollection<Meal> Meals { get; set; }
        public ICollection<Portion> Portions { get; set; }
    }
}