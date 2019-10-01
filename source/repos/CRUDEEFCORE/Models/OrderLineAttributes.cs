using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OrderLineAttributes
    {
        public string LocationCode { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public short LineNumber { get; set; }
        public short Sequence { get; set; }
        public string AttributeGroupCode { get; set; }
        public string AttributeCode { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
