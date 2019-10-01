using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class SdpVoucherDetails
    {
        public string LocationCode { get; set; }
        public int? OrderNumber { get; set; }
        public string VoucherName { get; set; }
        public string EmployeeCode { get; set; }
        public decimal? Amount { get; set; }
        public int? Quantity { get; set; }
        public int? OrderPayCode { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? Added { get; set; }
        public int? Isdeleted { get; set; }
    }
}
