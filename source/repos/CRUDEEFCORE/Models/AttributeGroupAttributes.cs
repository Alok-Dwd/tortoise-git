using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class AttributeGroupAttributes
    {
        public string LocationCode { get; set; }
        public string AttributeGroupCode { get; set; }
        public string AttributeCode { get; set; }
        public int? DisplayOrder { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }

        public virtual AttributeGroups AttributeGroups { get; set; }
        public virtual Attributes Attributes { get; set; }
        public virtual LocationCodes LocationCodeNavigation { get; set; }
    }
}
