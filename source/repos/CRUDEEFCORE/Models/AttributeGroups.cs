using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class AttributeGroups
    {
        public AttributeGroups()
        {
            AttributeGroupAttributes = new HashSet<AttributeGroupAttributes>();
        }

        public string LocationCode { get; set; }
        public string AttributeGroupCode { get; set; }
        public string Description { get; set; }
        public int? MaximumNumber { get; set; }
        public int? MinimumNumber { get; set; }
        public int? DisplayOrder { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
        public virtual ICollection<AttributeGroupAttributes> AttributeGroupAttributes { get; set; }
    }
}
