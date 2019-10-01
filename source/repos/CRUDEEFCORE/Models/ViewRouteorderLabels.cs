using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ViewRouteorderLabels
    {
        public string LocationCode { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public double? Labels { get; set; }
        public double? Other { get; set; }
    }
}
