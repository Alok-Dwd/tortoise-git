using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OrderDriverShiftLog
    {
        public string LocationCode { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string DriverId { get; set; }
        public string DriverShift { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
