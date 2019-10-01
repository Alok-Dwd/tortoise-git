using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MarketingQueryCodes
    {
        public string LocationCode { get; set; }
        public int QueryCode { get; set; }
        public int QueryIndex { get; set; }
        public int CriteriaCode { get; set; }
        public int OperatorCode { get; set; }
        public string BeginValue { get; set; }
        public string EndValue { get; set; }
        public int AndOr { get; set; }
        public int OperatorListIndex { get; set; }
        public string OpenParen { get; set; }
        public string CloseParen { get; set; }
    }
}
