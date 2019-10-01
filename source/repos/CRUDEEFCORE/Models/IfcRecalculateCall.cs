using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class IfcRecalculateCall
    {
        public string LocationCode { get; set; }
        public DateTime SystemDate { get; set; }
        public DateTime ProcessingDate { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime Added { get; set; }
    }
}
