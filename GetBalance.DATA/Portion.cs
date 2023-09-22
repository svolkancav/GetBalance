using GetBalance.DATA.Enums;

namespace GetBalance.DATA
{
	public class Portion
	{
		public int PortionId { get; set; }
		public double Quantity { get; set; }
        public PortionName PortionName { get; set; }
        public int FoodId { get; set; }

		public Food Food { get; set; }
	}
}