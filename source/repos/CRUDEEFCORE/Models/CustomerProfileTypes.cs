using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class CustomerProfileTypes
    {
        public CustomerProfileTypes()
        {
            CustomerProfileData = new HashSet<CustomerProfileData>();
        }

        public string LocationCode { get; set; }
        public int CustomerProfileTypeId { get; set; }
        public string ProfileDescription { get; set; }
        public short StatusCode { get; set; }
        public short ProfileControlTypeCode { get; set; }
        public int DisplayOrder { get; set; }
        public int MaxLength { get; set; }
        public bool RequiredProfile { get; set; }
        public string DefaultValue { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
        public virtual ICollection<CustomerProfileData> CustomerProfileData { get; set; }
    }
}
