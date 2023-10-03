using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBalance.DATA.Enums
{
	public enum PortionName
	{
		[Display(Name = "gram")]
		gram,
		[Display(Name = "millilitre")]
		milliliter,
		[Display(Name = "parça")]
		piece,
		[Display(Name = "dilim")]
		slice,
		[Display(Name = "çay kaşığı")]
		teaspoon,
		[Display(Name = "tatlı kaşığı")]
		tablespoon,
		[Display(Name = "fincan")]
		cup,
		[Display(Name = "şişe")]
		bottle,
		[Display(Name = "porsiyon")]
		portion,
		[Display(Name = "tabak")]
		plate,
		[Display(Name = "kase")]
		bowl,
		[Display(Name = "kutu")]
		box,
		[Display(Name = "bardak")]
		glass,
		[Display(Name = "adet")]
		amount,
		[Display(Name = "kadeh")]
		goblet, //kadeh
		[Display(Name = "diş")]
		clove, //diş
		[Display(Name = "tüm")]
		whole, //tüm
	}
}
