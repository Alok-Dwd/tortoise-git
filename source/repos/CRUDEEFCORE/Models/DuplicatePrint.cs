using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class DuplicatePrint
    {
        public int PrintId { get; set; }
        public string LocationCode { get; set; }
        public int? OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public string EmployeeCode { get; set; }
        public DateTime? PrintDate { get; set; }
    }
}
