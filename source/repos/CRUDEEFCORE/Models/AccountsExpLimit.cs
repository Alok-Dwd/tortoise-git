using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class AccountsExpLimit
    {
        public string LocationCode { get; set; }
        public int AccountId { get; set; }
        public string AccountCode { get; set; }
        public long DailyLimit { get; set; }
        public long WeeklyLimit { get; set; }
        public long MonthlyLimit { get; set; }
        public long YearlyLimit { get; set; }
        public bool? Active { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
