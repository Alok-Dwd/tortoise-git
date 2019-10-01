﻿using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OrderLineOptions
    {
        public string LocationCode { get; set; }
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public short LineNumber { get; set; }
        public short Sequence { get; set; }
        public string MenuOptionGroupCode { get; set; }
        public string MenuCode { get; set; }
        public string SizeCode { get; set; }
        public string PizzaPart { get; set; }
        public string AmountCode { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
