using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _16_DBFirst_RepositoryDesing_Nortwind.Repositories;
using GetBalance.DAL;
using GetBalance.DATA;

namespace GetBalance.UI.Repositories
{
	public class UserTargetRepository : GenericRepository<UserTarget>
	{
		AppDbContext context;
		public UserTargetRepository() : base()
		{
			context = new AppDbContext();
		}

		public void Update(UserTarget ut)
		{
			UserTarget userTarget = GetAll().First(x => x.UserTargetId == ut.UserTargetId);
			userTarget.TargetWeight = ut.TargetWeight;
			userTarget.TargetCalorie = ut.TargetCalorie;
			userTarget.TargetCarbPercentage = ut.TargetCarbPercentage;
			userTarget.TargetProteinPercentage = ut.TargetProteinPercentage;
			userTarget.TargetFatPercentage = ut.TargetFatPercentage;

			context.SaveChanges();
		}
	}
}
