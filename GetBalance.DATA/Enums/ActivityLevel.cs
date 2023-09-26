using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBalance.DATA.Enums
{
    public enum ActivityLevel
    {
        [Display(Name="Hareketsiz")]
        Sedentary,
		[Display(Name = "Hafif Aktif")]
		LightlyActive,
		[Display(Name = "Orta Derece Aktif")]
		ModeratelyActive,
		[Display(Name = "Yüksek Derece Aktif")]
		HighlyActive,
		[Display(Name = "Aşırı Derece Aktif")]
		ExtremelyActive
    }
}
