using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class VsMetrix
    {
        public string LocationCode { get; set; }
        public int MetricId { get; set; }
        public string Metric { get; set; }
        public string DataType { get; set; }
        public string Units { get; set; }
    }
}
