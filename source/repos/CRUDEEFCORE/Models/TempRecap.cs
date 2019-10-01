using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class TempRecap
    {
        public string CategoryName { get; set; }
        public decimal? DailyCost { get; set; }
        public decimal? DailyIdeal { get; set; }
        public decimal? DailyWaste { get; set; }
        public decimal? WtdCost { get; set; }
        public decimal? WtdIdeal { get; set; }
        public decimal? WtdWaste { get; set; }
    }
}
