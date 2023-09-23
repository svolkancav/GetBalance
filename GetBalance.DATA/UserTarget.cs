using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetBalance.DATA.Enums;

namespace GetBalance.DATA
{
    public class UserTarget
    {
        public int UserTargetId { get; set; }
        public double StartingWeight { get; set; }
        public double TargetWeight { get; set; }
        public DateTime StartingDate { get; set; }
        public ActivityLevel ActivityLevel { get; set; }
        public short TargetCalorie { get; set; }
        public byte TargetCarbPercentage { get; set; }
        public byte TargetProteinPercentage { get; set; }
        public byte TargetFatPercentage { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public int UserDetailId { get; set; }
        public UserDetail UserDetail { get; set; }



    }
}
