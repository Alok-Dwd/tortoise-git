using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CreditCardVendor
    {
        public string LocationCode { get; set; }
        public byte CreditCardId { get; set; }
        public string ExeName { get; set; }
        public int? TimeOut { get; set; }
        public string Status { get; set; }
        public string FieldFilter { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
        public int? ExePayMode { get; set; }
    }
}
