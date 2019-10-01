using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class PriorityCustomers
    {
        public string LocationCode { get; set; }
        public int Id { get; set; }
        public byte[] PhoneNo { get; set; }
        public int? CatgId { get; set; }
        public bool? Status { get; set; }
        public bool? Blocked { get; set; }
        public DateTime? AddedDate { get; set; }
        public string AddedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual PriorityCustomerCategory Catg { get; set; }
        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
