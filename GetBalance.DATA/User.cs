using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBalance.DATA
{
	public class User
	{
		public User()
		{
			Meals = new HashSet<Meal>();
		}
		public int UserId { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public DateTime RegistrationDate => DateTime.Now;
		public UserDetail UserDetail { get; set; }
		public ICollection<Meal> Meals { get; set; }
    }
}
