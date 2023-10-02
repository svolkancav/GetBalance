using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBalance.DATA.Entities
{
    public class FoodCategory
    {
        public FoodCategory()
        {
            Foods = new HashSet<Food>();
        }
        public int FoodCategoryId { get; set; }
        public string Name { get; set; }

        public ICollection<Food> Foods { get; set; }
    }
}
