using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ViewIfctoppings
    {
        public string LocationCode { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public short LineNumber { get; set; }
        public short Sequence { get; set; }
        public string MenuOptionGroupCode { get; set; }
        public string PizzaPart { get; set; }
        public string InvMenuCode { get; set; }
        public int? ToppingCount { get; set; }
    }
}
