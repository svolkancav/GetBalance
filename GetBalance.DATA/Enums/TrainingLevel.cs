using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GetBalance.DATA.Enums
{
    public enum TrainingLevel
    {
        [Display(Name = "Düşük")]
        Low,
        [Display(Name = "Orta")]
        Middle,
        [Display(Name = "Yüksek")]
        High,
        [Display(Name = "Çok Yüksek")]
        VeryHigh
    }
}
