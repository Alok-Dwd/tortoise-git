using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ReasonDetails
    {
        public string LocationCode { get; set; }
        public int ReasonId { get; set; }
        public int OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime Added { get; set; }
        public string HotelName { get; set; }
        public string AddedBy { get; set; }
        public string CouponCode { get; set; }
        public int Sequence { get; set; }
    }
}
