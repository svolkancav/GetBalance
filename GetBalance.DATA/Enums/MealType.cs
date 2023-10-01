using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBalance.DATA.Enums
{
	public enum MealType
	{
		[Display(Name = "Kahvaltı")]
		Breakfast,
		[Display(Name = "Öğle Yemeği")]
		Lunch,
		[Display(Name = "Akşam Yemeği")]
		Dinner,
		[Display(Name = "Atıştırmalık")]
		Snack
	}
}
