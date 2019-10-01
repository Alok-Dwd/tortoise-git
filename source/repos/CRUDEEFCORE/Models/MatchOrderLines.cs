using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MatchOrderLines
    {
        public int? OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public bool? Status { get; set; }
    }
}
