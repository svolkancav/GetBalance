using GetBalance.DATA.Enums;

namespace GetBalance.DATA.Entities
{
    public class Food
    {
        public Food()
        {
            FoodMeals = new HashSet<FoodMeal>();
        }
        public int FoodId { get; set; }
        public string Name { get; set; }
        public int UnitPortionQuantity { get; set; }
        public PortionName PortionName { get; set; }
        public double Calories { get; set; }
        public double Protein { get; set; }
        public double Carbohydrate { get; set; }
        public double Fat { get; set; }
        public int CategoryId { get; set; }
        public string? Picture { get; set; }

        public FoodCategory FoodCategory { get; set; }
        public ICollection<FoodMeal> FoodMeals { get; set; }
    }
}