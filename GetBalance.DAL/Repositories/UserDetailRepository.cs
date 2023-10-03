using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _16_DBFirst_RepositoryDesing_Nortwind.Repositories;
using GetBalance.DATA.Entities;

namespace GetBalance.DAL.Repositories
{
	public class UserDetailRepository : GenericRepository<UserDetail>
	{
        AppDbContext context;
        public UserDetailRepository() : base()
        {
            context = new AppDbContext();
        }

        public void Update(UserDetail ud,int id)
        {
			UserDetail userDetail = GetAll().First(x => x.UserId == id);
			userDetail.Height = ud.Height;
			userDetail.CurrentWeight = ud.CurrentWeight;
			userDetail.NeckCircumference = ud.NeckCircumference;
			userDetail.WaistCircumference = ud.WaistCircumference;
			userDetail.HipCircumference = ud.HipCircumference;
			userDetail.ActivityLevel = ud.ActivityLevel;
			userDetail.TrainingLevel = ud.TrainingLevel;
			context.UserDetails.Update(userDetail);
			context.SaveChanges();
		}
    }
}
