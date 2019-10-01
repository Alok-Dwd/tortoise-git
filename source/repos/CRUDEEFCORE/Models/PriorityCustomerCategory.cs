using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class PriorityCustomerCategory
    {
        public PriorityCustomerCategory()
        {
            PriorityCustomers = new HashSet<PriorityCustomers>();
        }

        public string LocationCode { get; set; }
        public int CatgId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Symbol { get; set; }
        public int? CatgRank { get; set; }
        public DateTime? AddedDate { get; set; }
        public string AddedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
        public virtual ICollection<PriorityCustomers> PriorityCustomers { get; set; }
    }
}
