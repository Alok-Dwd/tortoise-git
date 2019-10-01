using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ViewInventoryVendors
    {
        public string LocationCode { get; set; }
        public string InventoryCode { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string VendorCode { get; set; }
        public string CompanyName { get; set; }
    }
}
