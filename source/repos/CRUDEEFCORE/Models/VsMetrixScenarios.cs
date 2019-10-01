using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class VsMetrixScenarios
    {
        public string LocationCode { get; set; }
        public string Scenario { get; set; }
        public string Metric { get; set; }
        public int RecordId { get; set; }
        public int ValueCount { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }
        public string Value4 { get; set; }
        public string Value5 { get; set; }
    }
}
