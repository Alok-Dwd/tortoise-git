using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class VsThresholdOperators
    {
        public string LocationCode { get; set; }
        public int OperatorId { get; set; }
        public string OperatorName { get; set; }
        public string OperatorValue { get; set; }
        public byte? DataType { get; set; }
    }
}
