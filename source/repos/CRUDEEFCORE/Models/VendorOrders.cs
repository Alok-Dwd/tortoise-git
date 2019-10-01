using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class VendorOrders
    {
        public string LocationCode { get; set; }
        public int VendorOrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string VendorCode { get; set; }
        public string VendorName { get; set; }
        public decimal ProjectedSales { get; set; }
        public DateTime HistoryBeginDate { get; set; }
        public DateTime HistoryEndDate { get; set; }
        public decimal OrderTotal { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
        public int? IsUpload { get; set; }
    }
}
