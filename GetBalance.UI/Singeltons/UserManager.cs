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
		private static readonly object lockObject = new object();

		public User CurrentUser { get; set; }

		private UserManager()
		{

		}

		public static UserManager Instance
		{
			get
			{
				// Eğer instance null ise, kilitlenir ve tekrar kontrol edilir.
				if (instance == null)
				{
					lock (lockObject)
					{
						// Birden fazla iş parçacığı buraya gelebilir, bu yüzden tekrar kontrol edilir.
						if (instance == null)
						{
							instance = new UserManager();
						}
					}
				}
				return instance;
			}
		}
	}
}
