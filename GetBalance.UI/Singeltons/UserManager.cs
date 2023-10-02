using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetBalance.DATA.Entities;

namespace GetBalance.UI.Singeltons
{
    public class UserManager
	{
		private static UserManager instance;
		public User CurrentUser { get; set; }

		private UserManager()
		{

		}

		public static UserManager Instance { get { return instance ?? (instance = new UserManager()); } }
	}
}
