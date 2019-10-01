using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class EmployeePosition
    {
        public string LocationCode { get; set; }
        public string EmployeeCode { get; set; }
        public string PositionCode { get; set; }
        public decimal PayRate { get; set; }
        public decimal MileageRate1 { get; set; }
        public decimal MileageRate2 { get; set; }
        public short DisplayOrder { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
