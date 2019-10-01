using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class EmployeeCashDrop
    {
        public string LocationCode { get; set; }
        public string EmployeeCode { get; set; }
        public DateTime SystemDate { get; set; }
        public decimal Amount { get; set; }
        public byte Shift { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
