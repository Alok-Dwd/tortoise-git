using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ViewTimeClock
    {
        public string EmployeeCode { get; set; }
        public string EmployeeCodeName { get; set; }
        public string GovernmentId { get; set; }
        public decimal PayRate { get; set; }
        public decimal? BonusPay { get; set; }
        public decimal? ExcessMileage { get; set; }
        public decimal? TotalPay { get; set; }
        public double? Hours15 { get; set; }
        public double? Hours20 { get; set; }
        public double? Hours25 { get; set; }
    }
}
