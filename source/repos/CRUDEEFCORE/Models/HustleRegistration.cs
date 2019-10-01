using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class HustleRegistration
    {
        public string LocationCode { get; set; }
        public string CompanyName { get; set; }
        public string OwnerName { get; set; }
        public string KeyString { get; set; }
        public DateTime CurrentDate { get; set; }
        public DateTime RegDate { get; set; }
    }
}
