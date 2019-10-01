using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class VsThresholdConditions
    {
        public string LocationCode { get; set; }
        public int ThresholdId { get; set; }
        public int ConditionId { get; set; }
        public int Metric { get; set; }
        public int Operator { get; set; }
        public bool CompareMetric { get; set; }
        public string CompareValue { get; set; }
        public int Conjunction { get; set; }
        public bool OpenParenth { get; set; }
        public bool CloseParenth { get; set; }
    }
}
