using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetBalance.DATA;

namespace GetBalance.UI.Events
{
	public delegate void AddedInfo();
	public class FormEventService
	{
		public event AddedInfo NewItemAdded;
		public event AddedInfo UserDetailUpdated;
		public event AddedInfo UserTagetUpdated;

		public void OnNewItemAdded()
		{
			NewItemAdded?.Invoke();
		}

		public void OnUserDetailUpdated()
		{
			UserDetailUpdated?.Invoke();
		}

		public void OnUserTagetUpdated()
		{
			UserTagetUpdated?.Invoke();
		}

		private static FormEventService _instance;

		public static FormEventService Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new FormEventService();
				}
				return _instance;
			}
		}

	}
}
