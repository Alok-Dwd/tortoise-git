using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class EodprocessLog
    {
        public decimal CountNumber { get; set; }
        public string LocationCode { get; set; }
        public DateTime LocationDate { get; set; }
        public DateTime SystemDate { get; set; }
        public string ProcessName { get; set; }
        public string ProcessStatus { get; set; }
        public string EmployeeCode { get; set; }
    }
}
