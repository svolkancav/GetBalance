
using _16_DBFirst_RepositoryDesing_Nortwind.Repositories;
using GetBalance.DAL;
using GetBalance.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBalance.UI.Repositories
{
    public class FoodRepository : GenericRepository<Food>
    {
        private AppDbContext context;

        public FoodRepository()
        {
            context = new AppDbContext();
        }
        public List<Food> GetByFilterName(string filterString)
        {
            return context.Foods.Where(x => x.Name.Contains(filterString)).ToList();
        }
    }
}
